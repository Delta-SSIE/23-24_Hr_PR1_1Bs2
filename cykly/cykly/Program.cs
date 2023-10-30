// See https://aka.ms/new-console-template for more information
using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Zadej cislo pro delitelnost:");
        int delitel = int.Parse(Console.ReadLine());
        int cislo = delitel + 1;

        while (cislo % delitel != 0)
        {
            Console.WriteLine("Zadej cislo delitelne " + delitel + ":");
            cislo = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Vysledek deleni cislem " + delitel + " je: " + cislo / delitel);

        /* int cislo;
          do{
            Console.WriteLine("Zadej cislo delitelne 5: ");
           cislo = int.Parse(Console.ReadLine());    
          }while(cislo%5 != 0);
          Console.WriteLine("Vysledek deleni cislem 5 je: " + cislo/5);*/
    }
}