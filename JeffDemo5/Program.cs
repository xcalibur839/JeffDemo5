using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 5; //Don't create these variables until after demonstrating foreach
            bool keepLooping = false; //Use this variable to demonstrate while and do...while

            //Start with an example that he is likely already somewhat familiar with
            foreach (string arg in args)
            {
                Console.WriteLine("You entered the argument: {0}", arg);
            }
            Console.WriteLine("No more arguments");

            while(loopCount > 0) //Use this opportunity to demonstrate endless loops by not satisfying the condition at first. 
                                 //See if he can figure out how to terminate the loop on his own.
                                 //May also want to demonstrate != vs. > by decrementing loopCount by values other than 1.
            {
                Console.WriteLine("The value of loopCount is {0}", loopCount--); //Demonstrate both decrementing and the -= operator
                //loopCount -= 1;
            }

            //Demonstrate do...while and the reasons to use it over while or for loops
            do
            {
                if (loopCount-- == 0) //Use this opportunity to demonstrate decrementing before and after evaluating
                {
                    keepLooping = true;
                }
                else if(loopCount == -5)
                {
                    keepLooping = false;
                }
                Console.WriteLine("Inside of the do...while loop. keepLooping is currently: {0}, and loopCount is currently {1}", keepLooping, loopCount);
            } while (keepLooping);

            for (int i = 0; i < args.Length; i++) //Probably best to save the weird syntax loops for the end, like for
                                                  //Best not to overwhelm him at this point. This is a lot of new info
            {
                Console.WriteLine("The argument at position {0} is {1}", i, args[i]);
            }

            Console.ReadLine();
        }
    }
}
