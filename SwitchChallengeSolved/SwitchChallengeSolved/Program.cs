using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallengeSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentOption = 1;
            /* This program ask for an option and depending the option selected we are going to 
             * invoke a specific function 
             * The challenge is: Change the multiple if statements into a SWITCH CASE.
             * 
             * EXTRA CHALLENGE: PUT A TRY-CATCH METHOD TO VALID AN INTEGER
             */
            while (currentOption != 0)
            {
                /* HINT: START FROM HERE  for the try-catch */
                try
                {
                    Console.WriteLine("Provide me an option (1 or 2). 0 for exit");
                    currentOption = Convert.ToInt32(Console.ReadLine());

                    /* HINT: START FROM HERE  to the switch :) */
                    switch (currentOption)
                    {
                        case 1:
                            option1Selected();
                            break;
                        case 2:
                            option2Selected();
                            break;
                        case 0:
                            Console.WriteLine("You selected option 0 (exit). Good bye :) ");
                            break;
                        default:
                            Console.WriteLine("Any option is valid, try with another one ");
                            break;
                    }

                    
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            


            }

            Console.WriteLine("We have finished. Press any key to exit.");
            Console.ReadKey();
        }


        static void option1Selected()
        {
            Console.WriteLine("You selected option 1");
        }

        static void option2Selected()
        {
            Console.WriteLine("You selected option 2");
        }
    }
}
