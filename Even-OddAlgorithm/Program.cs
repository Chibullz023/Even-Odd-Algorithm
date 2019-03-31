using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_OddAlgorithm
{
    class Program
    {
        /* Create an algorithm that counts down from 50 to -50
         * All odd numbers print I'm Odd number
         * All even numbers print I'm Even number */

        static void Main(string[] args)
        {
            for (int a = 50; a >= -50; a--)
            {
                /* Used to see if the remander for the numbers are above 0 and thus odd.
                   Negative numbers need to check if remander is -1 so less than  0 */
                if (a % 2 > 0 || a % 2 < 0)
                {
                    Console.WriteLine("{0} is an odd number.", a);
                }

                // All other numbers will print as even
                else
                {
                    Console.WriteLine("{0} is an even number", a);
                }
            }
            Console.ReadLine();
        }
    }
}
