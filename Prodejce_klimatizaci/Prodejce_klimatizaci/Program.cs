using Prodejce_klimatizaci;

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