using System;


namespace Homework3
{
		internal class Program {

        static void Main (string [] args)
        {
            // Task1 
            Console.WriteLine("Task 1: ");

            string[] array = { "", "sweet", "dream", "cute", "cats", "dogs", "mice", "elephants"};

            foreach (string arg in array)
            {
                if (arg.Length == 4)
                {
                    Console.WriteLine(arg);
                }
            }
            // Task2
            Console.WriteLine("Task 2: ");

            Shape circle = new Circle(12.3);
            circle.Area();

            Shape triangle = new Triangle(12, 4);
            triangle.Area();

            Shape trapezoid = new Trapezoid(12, 10, 5);
            trapezoid.Area();

            // Task3
            Console.WriteLine("Task 3: ");

            Tree one = new Tree(1);
            one.Print();
            Tree two = new Tree("deciduous", "oak", 8);
            two.Print();



        
        }

}
}




