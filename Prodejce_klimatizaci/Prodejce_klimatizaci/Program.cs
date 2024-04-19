using Prodejce_klimatizaci;

List <Prodejce> seznamProdejcu = new List <Prodejce> ();
int volba = 0;
while(volba != 3)
{
     volba = vypisMenu();
    uloha(volba);
}





int vypisMenu() {
    int volba = 0;
    while (true)
    {
        Console.WriteLine("Vitej v evidenci prodejcu");
        Console.WriteLine("1. vytvoreni prodejce");
        Console.WriteLine("2. prepnuti na rezim prodejce");
        Console.WriteLine("3. ukonceni programu");
        Console.WriteLine("Vase volba");
        if (int.TryParse(Console.ReadLine(), out volba) && volba>=1 && volba<=3)
        {
            break;
        }
    }
    return volba;
}

void uloha(int volba) {
    switch (volba)
    {
        case 1:
            String nazev;
            String sidlo;
            String telefon;
            Console.WriteLine("Zadej nazev:");
            nazev = Console.ReadLine();
            Console.WriteLine("Zadej sidlo:");
            sidlo = Console.ReadLine();
            Console.WriteLine("Zadej telefon:");
            telefon = Console.ReadLine();
            Prodejce novy = new Prodejce(nazev, sidlo, telefon);
            seznamProdejcu.Add(novy);
            Console.WriteLine("Prodejce byl pridan!");
            break;
        case 2:
            Console.WriteLine("Zadej nazev prodejce pro prepnuti:");
            String nazevProdejce = Console.ReadLine();
            Prodejce hledani = new Prodejce(nazevProdejce, "", "");
            Console.WriteLine(seznamProdejcu.Find(x => x.GetNazev().Contains(nazevProdejce)).GetNazev());
            break;
        case 3: break;


    }
}