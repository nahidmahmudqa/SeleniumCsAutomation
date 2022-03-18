using System;

    namespace CSharpFundas
    {
       class Program : InheritParent
        {
        private string v;

        public Program(string v)
        {
            this.v = v;
        }

        public void getData()
        {
                Console.WriteLine("I am inside the method");
        }
         static void Main(string[] args)
        {
            Program p= new Program();
            p.getData();
            p.SetData();
            

            Console.WriteLine("Hello World");

            int a = 4;
            Console.WriteLine(a);

            String Name = "Nahid";
            Console.WriteLine("Name is " + Name);
            Console.WriteLine($"Name is { Name}");

            var age = 23;
            Console.WriteLine($"Age is {age}");
            //age="hello"  ||Can't run as it can't convert;

            dynamic height = 13.2;
            Console.WriteLine($"Height is {height}");

            height = "hello"; // can convert to anything 
            Console.WriteLine($"Height is {height}");


            }
        }
    }


