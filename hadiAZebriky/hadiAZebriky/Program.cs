// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vitejte ve hre hadi a zebriky");
Random kostka = new Random();
int pozice = 1;
int pocetHodu = 0;
int hod;

while (true)
{
    //provedeni hodu kostkou
    hod = kostka.Next(1, 7);
    pocetHodu++;
    pozice = pozice + hod;
    //testovani hadi, zebriky a nic
    if (pozice % 11 == 0)
    {
        pozice = pozice + 10;
        Console.WriteLine("Tah: " + pocetHodu + " Padl zebrik, posouvas se o 10, nova pozice " + pozice);

    }
    else if (pozice % 13 == 0)
    { 
            pozice = pozice - 12;
            Console.WriteLine("Tah: " + pocetHodu + " Padl had, vracis se o 12, nova pozice " + pozice);
        continue;
    }

    else
    {
        Console.WriteLine("Tah: " + pocetHodu + " Bezny tah, pozice prictena. Soucasna pozice " + pozice);
    }


    if (pozice >= 100)
    {
        Console.WriteLine("Tah: " + pocetHodu + " Vyhral jsi! Hra konci. Konecna pozice " + pozice);
        break;
    }
}

