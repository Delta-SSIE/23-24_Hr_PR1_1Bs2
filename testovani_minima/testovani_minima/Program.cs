using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int pozice = 0;
        int minimum = 0;
        int cislo = 1; //nastavim na hodnotu, ktera projde do cyklu

        while (cislo > 0)
        {
            Console.WriteLine("Zadej hodnotu: "); //protoze nastavena hodnota nesmi byt zapocitana do zadanych cisel, hned nacteme od uzivatele spravne cislo
            cislo = int.Parse(Console.ReadLine());
            if (cislo > 0)
            { //kdyby bylo cislo od uzivatele zaporne, nechci ho testovat, ani zapocitat jeho zadani do pozice
                pozice++;
                if (pozice == 1)
                { //pokud je zadavano prvni cislo, automaticky se stava maximem (pokud bych to neudelala, zadna hodnota by nebyla mensi nez 0, protoze by to automaticky ukoncovalo cyklus)
                    minimum = cislo;
                }
                else
                  if (pozice % 4 == 0)
                { //v zadani je, ze mame testovat pouze pozice na nasobcich 4
                    if (cislo < minimum)
                    { //otestuju hodnotu
                        minimum = cislo;
                    }
                }


            }
        }
        if (pozice < 4)
        {
            Console.WriteLine("Zadano mene cisel nez 4.");
        }
        else
        {
            Console.WriteLine("Pocet zadanych cisel je: " + pozice);
            Console.WriteLine("Minimum je: " + minimum);
        }
    }
}
