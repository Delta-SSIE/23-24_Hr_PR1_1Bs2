Console.WriteLine("Vitejte v nakupnim seznamu 1.0");
int volba;
while (true)
{
   volba = menu();
    if (volba == 0)
    {
        Console.WriteLine("Dekujeme za vyuziti programu.");
        break;
    }
    else {
        switch (volba) {
            case 1: break;
            case 2: break;
            case 3: break;
            case 4: break;
        }
    }
}
static int menu() {
    int volba;
    while (true)
    {
        Console.WriteLine("1. Vytvor seznam");
        Console.WriteLine("2. Pridej polozky");
        Console.WriteLine("3. Vyhledej");
        Console.WriteLine("4. Odeber polozku");
        Console.WriteLine("0 Ukoncit program");
        if (int.TryParse(Console.ReadLine(), out volba) && (volba>=0 && volba<=4) )
            break;
        else
        { 
            Console.WriteLine("Neplatna volba.");
            continue;
        }

    }
        return volba;
}
