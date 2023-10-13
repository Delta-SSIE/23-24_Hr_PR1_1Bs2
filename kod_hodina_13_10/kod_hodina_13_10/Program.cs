using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej citatel:");
        int citatel = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej jmenovatel:");
        int jmenovatel = int.Parse(Console.ReadLine());
        if (citatel < jmenovatel)
        {
            Console.WriteLine("Nelze zapisovat smisene cislo.");
        }
        else
        {
            if (jmenovatel == 0)
                Console.WriteLine("neplatny zlomek");

            if (citatel % jmenovatel == 0)
            {
                Console.WriteLine("Vysledne cislo je: " + citatel / jmenovatel);
            }
            else
            {
                int cele = citatel / jmenovatel;
                int smisene = citatel - (cele * jmenovatel);
                Console.WriteLine("Vysledek je: " + cele + " " + smisene + "/" + jmenovatel);

            }

        }
    }
}
