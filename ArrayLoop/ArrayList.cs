using System;
using System.Collections;

ArrayList a = new ArrayList();
a.Add("hello");
a.Add("bye");
a.Add("Nahid");
a.Add("Apple");

Console.WriteLine(a[1]);

foreach (String item in a)
{
    Console.WriteLine(item);
}
Console.WriteLine(a.Contains("Nahid"));
Console.WriteLine("After Sorting");
a.Sort();

foreach (String item in a)
{
    Console.WriteLine(item);
}


ArrayList Mahmud = new ArrayList();
Mahmud.Add("Mahmud 0");
Mahmud.Add("Rasel");

Console.WriteLine(Mahmud[0]);

ArrayList nahid = new ArrayList { "Mahmud", "Rasel" };
foreach (String print in nahid)
{
    Console.WriteLine(print);
}

Console.WriteLine(nahid.Contains("Rasel")); //True or False