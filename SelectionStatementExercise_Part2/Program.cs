using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Ask the user for their favorite school subject.  
               2. Store their answer in a variable
               3. Pass the variable as the expression in a switch statement.
               4. Create 5 different cases for different subjects.  Each case will print the subject chosen and a custom message of your choosing.
               5. Create a default case to handle any case not handled.
             */

            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("\r\nMath is fun... Once you get the hang of it... Heh...");
                    break;
                case "science":
                    Console.WriteLine("\r\nScience is neat. Chemistry was my favorite kind of science.");
                    break;
                case "history":
                    Console.WriteLine("\r\nHistory is an interesting class, but I lost interest in high school.");
                    break;
                case "pe":
                    Console.WriteLine("\r\nPE was fun, especially when we got to play dodge ball!");
                    break;
                case "spanish":
                    Console.WriteLine("\r\nI wish I would have paid attention in Spanish class!");
                    break;
                default:
                    Console.WriteLine("\r\nYour subject wasn't included. :(");
                    break;
            }

            Console.ReadLine();
        }
    }
}
