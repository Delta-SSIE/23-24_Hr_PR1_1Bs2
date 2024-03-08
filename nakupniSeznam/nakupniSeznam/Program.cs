Console.WriteLine("Vitejte v nakupnim seznamu 1.0");
int volba;
bool vytvoren = false;
List<String> nakupniSeznam = new List<String>();

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
            case 1:
                Console.WriteLine("Zadej nazev polozky");
                String polozka = Console.ReadLine();
                nakupniSeznam.Add(polozka);
                Console.WriteLine("Polozka byla zapsana.");
                break;


            case 2: break;
            case 3: break;
            case 4:
                foreach ( String p in nakupniSeznam) {
                    Console.WriteLine("*    " + p);
                }
                break;
        }
    }
}
static int menu() {
    int volba;
    while (true)
    {
        Console.WriteLine("1. Pridej polozku");
        Console.WriteLine("2. Vyhledej");
        Console.WriteLine("3. Odeber polozku");
        Console.WriteLine("4. Vyhledej");
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
