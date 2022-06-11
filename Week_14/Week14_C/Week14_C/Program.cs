using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_C
{
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
        public double Height;

        public override string ToString()
        {
            return $"{Name},{Phone},{Age:D3},{Height:F1}";
            //return $"{Name},{Phone},{Age:000},{Height:000.0}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NameCard nc1, nc2;

            nc1 = new NameCard();
            nc1.Name = "김인하";
            nc1.Phone = "010-2222-1111";
            nc1.Age = 21;
            nc1.Height = 160.7;

            nc2 = new NameCard();
            nc2.Name = "이인하";
            nc2.Phone = "010-1111-1111";
            nc2.Age = 23;
            nc2.Height = 171.7;

            List<NameCard> list = new List<NameCard>();
            list.Add(nc1);
            list.Add(nc2);

            //string path = "c:\\final_c";
            string path = "c:\\final_c";

            if(false == Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            do
            {
                Console.WriteLine("1:이진파일쓰기");
                Console.WriteLine("2:이진파일읽기");
                Console.WriteLine("3:텍스트파일쓰기");
                Console.WriteLine("4:텍스트파일읽기");
                Console.WriteLine("5:텍스트파일리스트쓰기");
                Console.WriteLine("6:텍스트파일리스트읽기");
                Console.WriteLine("0:끝");

                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        var f1 = path + "\\test.dat";
                        Method1(f1, nc1);
                        Console.WriteLine(f1 + "파일 확인");
                        break;

                    case "2":
                        var f2 = path + @"\test.dat";
                        NameCard rnc1;
                        Method2(f2, out rnc1);
                        if(rnc1 != null)
                        {
                            // Namecard를 호출할시 기본적으로 tostring이 나옴
                            Console.WriteLine(rnc1);
                        }
                        break;

                    //기말 3456 무조건 알아야함
                    case "3":
                        var f3 = Path.Combine(path, "test.txt");
                        Method3(f3, nc2);
                        Console.WriteLine(f3 + "파일을 확인하세요.");
                        break;

                    case "4":
                        var f4 = Path.Combine(path, "test.txt");
                        Method4(f4, out NameCard rnc2);
                        if(rnc2 != null)
                        {
                            Console.WriteLine(rnc2);
                        }
                        break;
                    case "5":
                        var f5 = Path.Combine(path, "testlist.txt");
                        Method5(f5, list);
                        Console.WriteLine(path + "파일을 확인하세요");
                        break;
                    case "6":
                        var f6 = Path.Combine(path, "testlist.txt");
                        Method6(f6, out List<NameCard> rcvlist);
                        if(rcvlist != null)
                        {
                            foreach(var item in rcvlist)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    
                    case "0":
                        return;
                }
            }
            while (true);
        }

        private static void Method6(string file, out List<NameCard> list)
        {

            list = null;

            if(File.Exists(file) == false)
            {
                return;
            }

            using (var fs = new FileStream(file, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    foreach (var nc in list)
                    {
                        list = new List<NameCard>();
                        while(sr.EndOfStream == false)
                        {
                            string record = sr.ReadLine();
                            string[] data = record.Split(',');
                            if(data.Length == 4)
                            {
                                NameCard mc = new NameCard();
                                mc.Name = data[0].Trim();
                                mc.Phone = data[1].Trim();
                                mc.Age = int.Parse(data[2].Trim());
                                mc.Height = double.Parse(data[3].Trim());
                                list.Add(mc);
                            }
                        }
                    }
                }
            }
        }

        private static void Method5(string file, List<NameCard> list)
        {
            //Append vs. Create
            using(var fs = new FileStream(file, FileMode.Append)){
                using (var sw = new StreamWriter(fs))
                {
                    foreach(var nc in list)
                    {
                        sw.WriteLine(nc);
                    }
                }
            }
        }

        private static void Method4(string file, out NameCard nc)
        {
            nc = null;

            if(false == File.Exists(file))
            {
                return;
            }

            using(var sr = new StreamReader(new FileStream(file, FileMode.Open)))
            {
                nc = new NameCard();
                nc.Name = sr.ReadLine();
                nc.Phone = sr.ReadLine();
                int.TryParse(sr.ReadLine(), out nc.Age);
                nc.Height = double.Parse(sr.ReadLine());
            }
        }

        private static void Method3(string file, NameCard nc)
        {
            using(var sw = new StreamWriter(new FileStream(file, FileMode.Create))){
                sw.WriteLine(nc.Name);
                sw.WriteLine(nc.Phone);
                sw.WriteLine(nc.Age); //int -> string -> byte
                sw.WriteLine(nc.Height); //double -> string -> byte
            }
        }

        private static void Method2(string file, out NameCard nc)
        {
            nc = null;
            if(File.Exists(file) == false)
            {
                return;
            }

            using (BinaryReader br = new BinaryReader(new FileStream(file, FileMode.Open)))
            {
                nc = new NameCard();
                //주의점: 쓴 순서대로 읽는다.
                nc.Name = br.ReadString();
                nc.Phone = br.ReadString();
                nc.Age = br.ReadInt32();
                nc.Height = br.ReadDouble();
            }

        }

        private static void Method1(string file, NameCard nc)
        {
            //FileStream fs = new FileStream(file, FileMode.Create);
            //BinaryWriter bw = new BinaryWriter(fs);
            //bw.Close();
            //fs.Close();

            //BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
            //bw.Close();

            //이 방식이 편할 것임
            //using (BinaryWriter bw
            //    = new BinaryWriter(new FileStream(file, FileMode.Create)))
            //{
            //
            //}

            using (var fs = new FileStream(file, FileMode.Create))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(nc.Name); //string -> bytes[]
                    bw.Write(nc.Phone); //string -> bytes[]
                    bw.Write(nc.Age); //int -> bytes[]
                    bw.Write(nc.Height); //double -> bytes[]
                }
            }
        }
    }
}
