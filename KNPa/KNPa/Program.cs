// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hra Kamen, Nuzky, Papir");
Random generator = new Random();
int tah = generator.Next(1, 4);
char prirazeno = ' ';
if (tah == 1)
{
    prirazeno = 'k';
}
else if (tah == 2)
{
    prirazeno = 'n';
}
else {
    prirazeno = 'p';
}

Console.WriteLine("Zadej svuj tah: k/n/p");
char volba = Console.ReadKey().KeyChar;
Console.WriteLine();
if (volba != 'k' && volba != 'n' && volba != 'p')
{
    Console.WriteLine("Zadana neplatna volba");
}
else {
    // Console.WriteLine("Zadana hodnota: ");
    // Console.WriteLine(volba);
    if (prirazeno == volba) {
        Console.WriteLine("Oba jste zvolili " + prirazeno + " a je to remiza.");
    }
    //varianta, ze vyhral uzivatel
    else if ((volba == 'p' && prirazeno == 'k') || (volba == 'k' && prirazeno == 'n') || (volba == 'n' && prirazeno == 'p')) {
        Console.WriteLine("Vyhral uzivatel: " + volba + ">" + prirazeno);
    }
    else //pokud nevyhral uzivatel a nebyla to remiza, musel vyhrat pocitac
        Console.WriteLine("Vyhral pocitac: " + prirazeno + ">" + volba);
}