using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var monthArr = new string[] { "January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "November", "December"};

            //for(var i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            //}

            //for(var i = 1; i < n; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine(monthArr[i]);
            //    } catch(IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"We have only provided 12 months because {n} months are over the limit of 12. (we are using 0-based)");
            //        break;
            //    }                
            //}

            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} is even.");
            } else
            {
                Console.WriteLine($"{n} is odd");
            }
        }
    }
}
