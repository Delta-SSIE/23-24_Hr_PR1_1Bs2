using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int cislo;
        // nastaveni krajnich hodnot intervalu pro cela cisla, pozor! hodnoty musi byt prohozene, protoze jinak by se uzivatel mohl stavet na hlavu a zadna hodnota by podminku nesplnila
        int minimum = int.MaxValue;
        int maximum = int.MinValue;
        int pocet = 0, soucet = 0;


        String vstup; // protoze muze zadat i pismeno, musime mit vstup nejdrive jako String
        while (true)
        {//nekonecny cyklus, vyhneme se pocatecnimu nastavovani hodnot - dalsi alternativa
            Console.WriteLine("Zadej hodnotu, X je pro ukonceni:");
            vstup = Console.ReadLine();
            if (vstup == "X")
            {
                Console.WriteLine("Konec.");
                break; //ukonceni programu
            }
            else
            {
                if (int.TryParse(vstup, out cislo))
                {//pokud jde vstup pretypovat na cislo, je to provedeno a dale s tim pracujeme
                    Console.WriteLine("Cislo vlozeno.");
                    pocet++; //zvysi se mi pocet vlozenych cisel
                    soucet = soucet + cislo;
                    //otestovani min a max, pro prvni pruchod to bude vzdy splneno a nastavi se diky tomu hodnota z prvniho pruchodu cyklem, potom uz se hodnoty budou porovnavat mezi sebou
                    if (cislo < minimum)
                        minimum = cislo;
                    if (cislo > maximum)
                        maximum = cislo;
                }
                else
                {
                    //program zjistil, ze vstup nejde pretypovat na cislo, tzn. ze byla vlozena neplatna hodnota, ale program nespadne a pokracuje v cyklu dal, kdyby se mel ukoncit, muselo by tu byt break
                    Console.WriteLine("Neplatna hodnota.");
                }
            }
        }
        Console.WriteLine("Prumer z hodnot je: " + (double)soucet / pocet);
        Console.WriteLine("Minimalni zadana hodnota je: " + minimum);
        Console.WriteLine("Maximalni zadana hodnota je: " + maximum);
    }
}
