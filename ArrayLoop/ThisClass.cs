using System;

namespace SeleniumCS
{
    public class ThisClass
    {
        string name;
        string lastname;

        //method default constructir
        public ThisClass(String name)
        {
            this.name = name;

        }

        public ThisClass(String firstname, String lastname)
        {
            this.lastname = lastname;

        }
        public void getName()
        {
            Console.WriteLine("My name is " + this.name);
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        }

        static void Main(string[] args)
        {
            ThisClass p = new ThisClass("Nahid"); //it's going to constructor
            // constructor will send name to global variable name

            ThisClass p1 = new ThisClass("Nahid", "Mahmud");

            Console.WriteLine("Second constructor executed ");
        }
    }
}
