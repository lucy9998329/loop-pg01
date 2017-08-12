using System;

namespace loops_pg01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            /*var counter = 5;
            for(var i = 0; i < counter; i++)
            {
                var a = i + 1;
                 Console.WriteLine($"This is line number {a+a}");
                 Console.ReadLine();
            }*/

            /*var counter = 5;
            var i = 0;
            while (i < counter)
            {
                var a = i + 1;
                Console.WriteLine($"This is line {a}"); i++;
                Console.ReadLine();
            }*/

            
            //declare variables
            //create a do/while loop
            //print the number of the lines to which the counter has been set
            var counter = 6;
            var i = 3;
            do
            {
                var a = i + 1;
                Console.WriteLine($"this is line {a}"); i++;
                Console.ReadLine();
            } while (i < counter);
            
           
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            

        }
    }
}
