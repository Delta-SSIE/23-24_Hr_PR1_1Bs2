Console.WriteLine("Zadej cislo:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Zadej mocninu:");
int mocnina = int.Parse(Console.ReadLine());
int hodnota = VypisMocninu(a, mocnina);
VypisVysledek(hodnota);

static int VypisMocninu (int a, int mocnina)
{
    int vysledek = 1;
    for (int i = 0; i < mocnina; i++)
    {
        vysledek = vysledek * a;
    }
    return vysledek;
}

static void VypisVysledek (int cislo) {
    Console.WriteLine("Vysledek je: " + cislo);
}
