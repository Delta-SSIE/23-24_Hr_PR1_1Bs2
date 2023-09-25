using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej vysledek tymu A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej vysledek tymu B:");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Vyhral tym A.");
        }
        else {
            Console.WriteLine("Vyhral tym B");
        }
    }
}
