using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        DataCollection dataCollection = new DataCollection();
        dataCollection.AddData("John", 25);
        dataCollection.AddData("Alice", 30);
        dataCollection.AddData("Bob", 40);
        dataCollection.AddData("Sarah", 28);
        dataCollection.AddData("David", 35);
        dataCollection.AddData("Emma", 42);
        dataCollection.AddData("Michael", 32);
        dataCollection.AddData("Olivia", 38);
        dataCollection.AddData("Daniel", 27);
        dataCollection.AddData("Sophia", 33);
        dataCollection.AddData("James", 41);
        dataCollection.AddData("Emily", 29);
        dataCollection.AddData("Jacob", 36);
        dataCollection.AddData("Ava", 43);
        dataCollection.AddData("Matthew", 31);
        dataCollection.AddData("Isabella", 37);
        dataCollection.AddData("Alexander", 26);
        dataCollection.AddData("Mia", 34);
        dataCollection.AddData("Ethan", 42);
        dataCollection.AddData("Charlotte", 39);

        Console.WriteLine("Original Data Collection:");
        dataCollection.PrintData();

        Console.WriteLine("\n--- Data Collection Methods and Properties ---");
        Console.WriteLine("Count: " + dataCollection.Count);
        Console.WriteLine("Item1 of the first data: " + dataCollection.GetFirstItem());
        Console.WriteLine("Contains data with name 'Alice': " + dataCollection.Contains("Alice"));
        Console.WriteLine("Index of data with name 'Bob': " + dataCollection.IndexOf("Bob"));
        Console.WriteLine("Last data: " + dataCollection.GetLastData());

        Console.WriteLine("\n--- MemberwiseClone Example ---");
        DataCollection cloneCollection = dataCollection.MemberwiseClone();
        Console.WriteLine("Cloned Data Collection:");
        cloneCollection.PrintData();

        Console.ReadLine();
    }
}
