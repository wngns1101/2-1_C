using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        class Student
        {
            private string name;
            public string Name { get; set; }
            private string number;
            public string Number { get; set; }
            public Student(string a, string b)
            {
                Name = a;
                Number = b;
            }

            public Student()
            {
            }
        }

        static void Main(string[] args)
        {

            string path = "C:\\Users\\이주훈\\Desktop\\2학년 1학기\\c# 프로그래밍\\final_exam";


            Student s1 = new Student("이주훈", "1234");
            Student s2 = new Student("표유림", "5675");

            List<Student> student = new List<Student>();
            student.Add(s1);
            student.Add(s2);

            if(false == Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            do
            {
                Console.WriteLine("1. 텍스트파일쓰기");
                Console.WriteLine("2. 텍스트파일읽기");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        var f1 = Path.Combine(path, "test.txt ");
                        Method1(f1, s1);
                        Console.WriteLine(f1 + "확인해보세용");
                        break;
                    case "2":
                        var f2 = Path.Combine(path, "test.txt ");
                        Method2(f2, out Student st);
                        if(st != null)
                        {
                            Console.WriteLine(st);
                        }
                        break;
                }
            } while (true);
        }

        private static void Method1(string file, Student stu)
        {
            using (var sw = new StreamWriter(new FileStream(file, FileMode.Create)))
            {
                sw.WriteLine(stu.Name);
                sw.WriteLine(stu.Number);
            }
        }

        private static void Method2(string file, out Student st)
        {
            st = null;
            if(File.Exists(file) == false)
            {
                return;
            }

            using (var sw = new StreamReader(new FileStream(file, FileMode.Open)))
            {
                st = new Student();

                st.Name = sw.ReadLine();
                st.Number = sw.ReadLine();
            }

                
        }
    }
}
