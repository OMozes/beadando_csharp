using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        DataCollection dataCollection = new DataCollection();
        dataCollection.AddData("Vivien", 25);
        dataCollection.AddData("Viktória", 30);
        dataCollection.AddData("Anna", 40);
        dataCollection.AddData("Alexandra", 28);
        dataCollection.AddData("Fanni", 35);
        dataCollection.AddData("Dóra", 42);
        dataCollection.AddData("Réka", 32);
        dataCollection.AddData("Petra", 38);
        dataCollection.AddData("Eszter", 27);
        dataCollection.AddData("Nikolett", 33);
        dataCollection.AddData("Dániel", 41);
        dataCollection.AddData("Dávid", 29);
        dataCollection.AddData("Bence", 36);
        dataCollection.AddData("Máté", 43);
        dataCollection.AddData("Tamás", 31);
        dataCollection.AddData("Péter", 37);
        dataCollection.AddData("Balázs", 26);
        dataCollection.AddData("Ádám", 34);
        dataCollection.AddData("Márk", 42);
        dataCollection.AddData("Zoltán", 39);

        Console.WriteLine("Adatok:");
        dataCollection.PrintData();

        Console.WriteLine("\n--- Metódusok és tulajdonságok ---");
        Console.WriteLine("Adatok száma: " + dataCollection.Count);
        Console.WriteLine("Az első név: " + dataCollection.GetFirstItem());
        Console.WriteLine("Van-e 'Tamás nevű ember? " + dataCollection.Contains("Tamás"));
        Console.WriteLine("'Nikolett' nevű ember indexe: " + dataCollection.IndexOf("Nikolett"));
        Console.WriteLine("Utolsó adat: " + dataCollection.GetLastData());

        Console.WriteLine("\n--- MemberwiseClone példa ---");
        DataCollection cloneCollection = dataCollection.MemberwiseClone();
        Console.WriteLine("Másolt adatgyűjtemény:");
        cloneCollection.PrintData();

        Console.ReadLine();
    }
}
