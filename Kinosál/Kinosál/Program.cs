using System.Reflection.Emit;

Console.WriteLine("Vitejte v kinosale");
int volba;
bool pokracovani = true;
int[,] kinosal = new int[5,5];
bool naplneno = false;


while (pokracovani) {
    Console.WriteLine("1) OTEVRI KINO");
    Console.WriteLine("2) REZERVUJ MISTO");
    Console.WriteLine("3) REZERVACE VICE MIST");
    Console.WriteLine("4) VYPIS KINO");
    Console.WriteLine("5) VYPIS SOUSEDNI MISTA");
    Console.WriteLine("6) KONEC");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Vase volba:");
    while (int.TryParse(Console.ReadLine(), out volba) == false) {
    Console.WriteLine("Neplatna volba. Zadej novou hodnotu.");
    }
switch (volba)
    {
        case 1:
            if (naplneno == false)
            {
                kinosal = naplnMatici(5, 0, 1);
                naplneno = true;
                Console.WriteLine("Kinosal byl naplnen");
            }
            else
                Console.WriteLine("Kinosal byl jiz otevren.");
            break;
        case 2:
            if (naplneno)
            {
                int rada;
                Console.WriteLine("Zadej cislo rady:");
                while(int.TryParse(Console.ReadLine(), out rada) == false )
                {
                    Console.WriteLine("Neplatna hodnota");

                }
                if (rada > 5)
                {
                    Console.WriteLine("Hodnota je mimo rozsah kinosalu. Opakujte volbu rezervace.");
                    break;
                }
              

                int sedadlo;
                Console.WriteLine("Zadej sedadlo:");
                while (int.TryParse(Console.ReadLine(), out sedadlo) == false)
                {
                    Console.WriteLine("Neplatna hodnota");

                }
                if (sedadlo > 5)
                {
                    Console.WriteLine("Hodnota je mimo rozsah kinosalu. Opakujte volbu rezervace.");
                    break;
                }

                if (kinosal[rada - 1, sedadlo - 1] == 0)
                {
                    kinosal[rada - 1, sedadlo - 1] = 1;
                    Console.WriteLine("Misto bylo rezervovano.");
                    vypisMatici(kinosal);
                }
                else 
                {
                    Console.WriteLine("Misto je jiz obsazeno.");
                }



                break;
            }

            else
                Console.WriteLine("Kinosal je nutne nejprve otevrit.");
            break;
            case 3:
            if (naplneno)
            {
              
                Console.WriteLine("Zadej pocet mist k rezervaci:");
                int pocet;
                while (int.TryParse(Console.ReadLine(), out pocet) == false) {
                    Console.WriteLine("Neplatna hodnota");
                }
                if (pocet > pocetVolno)
                {
                    Console.WriteLine("Neni dostupnych tolik mist");
                }
                else {
                  
                
                }
                
            }
            else
                Console.WriteLine("Nejprve je nutne kinosal otevrit.");
            break;
        
        case 4:
            if (naplneno)
            {
                Console.WriteLine("Vypis kinosalu: ");
                Console.WriteLine("----------------------------");
                vypisMatici(kinosal);
            }
            else
                Console.WriteLine("Nejprve je nutne kinosal otevrit.");
            break;
        case 5:
            break;
        case 6:
            pokracovani = false;
            break;

    }
}

static int[,] naplnMatici(int rozmer,  int dolniMez, int horniMez)
{
    int[,] pomocna = new int[rozmer, rozmer];
    Random generator = new Random();
    for (int i = 0; i < rozmer; i++)
    {
        for (int j = 0; j < rozmer; j++)
        {
            pomocna[i, j] = generator.Next(dolniMez, horniMez+1);
        }

    }
    return pomocna;
}

static void vypisMatici(int[,] matice) {
    for (int i = 0; i < matice.GetLength(0); i++)
    {
        for (int j = 0; j < matice.GetLength(1); j++)
        {
            Console.Write(matice[i, j] + " ");
        }
        Console.WriteLine();

    }
}



