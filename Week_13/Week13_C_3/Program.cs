#define A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            try
            {
                List<string> arr = new List<string>() { "가", "나" };
                input = int.Parse(Console.ReadLine());
            } catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("숫자 입력 다시");
            } catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("인덱스:" + input);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("종료");
            }
            
            /*
            int input = 0;
            try
            {
                string[] arr = { "가", "나" };
                input = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[input]);
            } catch(Exception ex){
                Console.WriteLine(ex.Message);
                Console.WriteLine("인덱스: " + input);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("--------");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("--------");
                Console.WriteLine(ex.ToString());
            } finally{
                Console.WriteLine("종료");
            }
            */
            /*
            string[] array = { "가", "나" };
            var input = int.Parse(Console.ReadLine());
#if A
            Console.WriteLine(array[input]);
#elif B
            if(input < array.Length) {
                 Console.WriteLine(array[input]);
                 }
#endif
            */
        }
    }
}
