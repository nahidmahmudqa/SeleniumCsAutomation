using System;

namespace CSharpFundas
{
    class ThisConstructor:InheritParent
    {
        String name;

        //Method default Constructor
        public Program(String name)
        {
            this.name = name;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        }
        static void Main(string[] args)

        {
            Program p = new Program("Nahid");
            p.getData();
            p.SetData();
            p.getName();

            String name = "Nahid";

        }
    }
}
