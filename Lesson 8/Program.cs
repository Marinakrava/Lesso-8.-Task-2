using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\yxakr\Desktop\Test\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path,false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-20, 20));
                }
            }
            int summ = 0;
            int number;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                   number= Convert.ToInt32(sr.ReadLine());
                   summ += number;
                    
                }
            }
            Console.WriteLine(summ);    
            Console.ReadKey();
        }
    }
}
