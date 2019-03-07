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
            #region task 2 and 3
            Console.Write("Enter 20 numbers:");
            int[] arrNumbers = new int[20];

            for (var i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Here are the numbers you entered");

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);

                if (arrNumbers[i] == 0)
                {
                    Console.WriteLine("Skipped");
                    continue;
                }
                if (Math.Abs(arrNumbers[i]).ToString().Length == 3)
                {
                    break;
                }
            }
            Console.ReadLine();
            #endregion
            #region task 1
            int[] intArray = new int[5];
            Console.WriteLine("Enter first number:");
            intArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            intArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            intArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            intArray[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fifth number:");
            intArray[4] = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i];
            }
            Console.WriteLine("The sum is: ");
            Console.WriteLine(result);
            Console.ReadLine();
            #endregion
        }
    }
}
