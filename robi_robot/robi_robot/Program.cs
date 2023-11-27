// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítejte u robota Robiho!");
int rozsah;
int pocetPohyb;

//zadání rozsahu a kontrola hodnoty - uzivatel nesmi zadat 0 nebo záporné čislo
while (true)
{
    Console.WriteLine("Zadejte velikost dráhy");
    rozsah = int.Parse(Console.ReadLine());
    if (rozsah > 0) {
        Console.WriteLine("Hodnota rozsahu byla nastavena.");
        break;
    }
    else { Console.WriteLine("Zadán nesprávný rozsah.");
    }
}
int pocetHracu;
while (true)
{
    Console.WriteLine("Kolik hráčů bude hrát? Zadej 1 pro jednoho hráče, 2 pro dva hráče");
pocetHracu = int.Parse(Console.ReadLine());
    if(pocetHracu == 1 || pocetHracu == 2)
    {
        Console.WriteLine("Pocet hracu byl nastaven na " + pocetHracu);
        break;
    }
    else
    { Console.WriteLine("Zadán nesprávný počet hráčů.");
    }
}

int aktualniPozice = 0;
string volba;
Console.WriteLine("Hra začíná!");
if (pocetHracu == 1)
{
    while (true)
    {
        //ukončení, pokud jsme na konci dráhy
        if (aktualniPozice == rozsah)
            break;

        Console.WriteLine("Zadejte příkaz: ");
        Console.WriteLine("ROVNE ... robot se posune vpřed");
        Console.WriteLine("ZPET ... robot se posune vzad");
        Console.WriteLine("PREHLED ... zobrazeni zbylého počtu polí");
        Console.WriteLine("KONEC ... ukončit hru");
        Console.WriteLine("............................");

        // Console.WriteLine("Aktualni pozice: " + aktualniPozice);
        Console.Write("Vase volba: ");
        volba = Console.ReadLine();
        volba = volba.ToUpper(); //aby to vždy odpovídalo se switch
     
        switch (volba)
        {
            case "ROVNE":
                Console.WriteLine("Zadej velikost posunu: ");
                pocetPohyb = int.Parse(Console.ReadLine());
                if (pocetPohyb > 0)
                {
                    if ((aktualniPozice + pocetPohyb) < rozsah)
                    {
                        aktualniPozice = aktualniPozice + pocetPohyb;
                        Console.WriteLine("Pohyb vpřed o " + pocetPohyb + " byl proveden.");
                    }
                    else if ((aktualniPozice + pocetPohyb) == rozsah)
                    {
                        aktualniPozice = aktualniPozice + pocetPohyb;
                        Console.WriteLine("Vítěz!");
                        break;
                    }
                }
                else
                    Console.WriteLine("Neplatná hodnota");
                break;
            case "ZPET":
                Console.WriteLine("Zadej velikost posunu: ");
                pocetPohyb = int.Parse(Console.ReadLine());
                if ((aktualniPozice - pocetPohyb) >= 0)
                {
                    aktualniPozice = aktualniPozice - pocetPohyb;
                    Console.WriteLine("Pohyb zpet o " + pocetPohyb + " byl proveden.");
                }
                break;
            case "PREHLED":
                Console.WriteLine("Zbyvajici pocet poli je: " + (rozsah - aktualniPozice));
                break;
            case "KONEC":
                Console.WriteLine("Nashledanou.");
                aktualniPozice = rozsah; //potrebujeme, aby se nam ukoncil cyklus nadrazeny
                break;

        }
    }
}
else
{
    int aktPoziceA = 0;
    int aktPoziceB = 0;
    bool hracA = true;
    while (aktPoziceA <= rozsah && aktPoziceB <= rozsah)
    {
        //testujeme, jestli nektery z hracu uz nedosel do cile
        if (aktPoziceA == rozsah || aktPoziceB == rozsah) {
            if (aktPoziceA == rozsah)
                Console.WriteLine("Do cile dosel driv hrac A");
            else
                Console.WriteLine("Do cile dosel driv hrac B");
            break;
        }
           
  


        if (hracA)
        {
            Console.WriteLine("Na tahu je hrac A");
            Console.WriteLine("Zadej pocet kroku: ");
            pocetPohyb = int.Parse(Console.ReadLine());
            if (aktPoziceA + pocetPohyb > rozsah)
                aktPoziceA = rozsah;
            else
            aktPoziceA = aktPoziceA + pocetPohyb;

            hracA = false;

        }
        else {
            Console.WriteLine("Na tahu je hrac B");
            Console.WriteLine("Zadej pocet kroku: ");
            pocetPohyb = int.Parse(Console.ReadLine());
            if (aktPoziceB + pocetPohyb > rozsah)
                aktPoziceB = rozsah;
            else
                aktPoziceB = aktPoziceB + pocetPohyb;
            hracA = true;
        }
    }
}