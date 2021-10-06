using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileChallengeSolved
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
            * The following program sums a lists of numbers.
            * 
            * The quantity of numbers will be asked at the begining.
            * 
            * The challenge is to use a while loop instead a for loop
            * 
            * 
            * */

            int quantity;
            int counter;
            int result = 0;

            Console.Write("How many numbers would like to sum? ");
            quantity = Convert.ToInt32(Console.ReadLine());

            /* HINT: START FROM HERE */
            counter = 0;
            while(counter < quantity)
            {
                int tempValue;
                Console.Write("Provide me the number {0}: ", counter + 1);
                tempValue = Convert.ToInt32(Console.ReadLine());
                result = result + tempValue;
                counter = counter + 1;
                // Also we can use counter++ 
            }

            Console.WriteLine("The summatory is equal to: {0}", result);
            Console.WriteLine("We have finished. Press any key to exit.");
            Console.ReadKey();

        }
    }
}
