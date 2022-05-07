using System;
namespace Homework3
{
    internal class Tree
    {

        private string _type;
        private string _name;
        private int _age;

        public Tree(int age)
        {
            _type = "";
            _name = "tree";
            _age = age;
        }

        public Tree(string type, string name, int age)
        {
            _type = type;
            _name = name;
            _age = age;
        }

        public void Print()
        {
            Console.WriteLine($"There is a {_age}-year-old {_type} {_name} in my garden");
        }
    }
}
