using System;


namespace Homework3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Task1 
            Console.WriteLine("Task 1: ");

            string[] array = { "", "sweet", "dream", "cute", "cats", "dogs", "mice", "elephants" };

            foreach (string arg in array)
            {
                if (arg.Length == 4)
                {
                    Console.WriteLine(arg);
                }
            }
            // Task2
            Console.WriteLine("Task 2: ");

            Shape obj = new Shape();
            obj.Area(12);
            obj.Area(5.5, 7);
            obj.Area(12,5,3.5);

            // Task3
            Console.WriteLine("Task 3: ");

            Tree one = new Tree(1);
            one.Print();
            Tree two = new Tree("deciduous", "oak", 8);
            two.Print();




        }

    }
}




