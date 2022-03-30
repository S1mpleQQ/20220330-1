using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_1
{
    class Program
    {
        static void Main(string[] args)
        {Random R =new Random();
            Console.Write("n=");
            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 50; i++)
            {
                int temp = R.Next(1,100);
                Console.WriteLine(temp);
                sum += temp;
            }
            Console.WriteLine(((double)sum) / n);
            Console.ReadLine();
                
                
               
            Console.WriteLine(R.Next(1,100));
            Console.WriteLine($"你輸出入的");
            Console.ReadLine();
        }
    }
}
