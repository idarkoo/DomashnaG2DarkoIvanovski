using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaG2DarkoIvanovski
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 20 numbers:");
            int[] arrNumbers = new int[20];
            
            for (var i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Here are the numbers you entered");

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);

                if (arrNumbers[i] == 0)
                {
                    Console.WriteLine("Skipped");
                    continue;
                }
                if(Math.Abs(arrNumbers[i]).ToString().Length == 3)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
