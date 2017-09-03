using System;

namespace _9998539problem02.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display the division tables of 1 to 12 of a provided number");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please provide a number that is less than 100");
            var number1 = Console.ReadLine();
            double value1 = 0;
            var isnumber = double.TryParse(number1, out value1);
            if(isnumber) {
                if(value1 < 100) {
                    var counter = 12;
                    var i = 0;

                    do {
                        var a = value1/(i+1);
                        Console.WriteLine(number1 + " / " + (i+1) + " = " + a);
                        i++;
                    } while (i<counter);
                }
                else {
                    Console.WriteLine("Please enter a value less than 100 next time");
                }
            }
            else {
                Console.WriteLine("please enter a number next time");
            }
            //To close program and clear console for next use.
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
