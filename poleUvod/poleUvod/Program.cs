// See https://aka.ms/new-console-template for more information
int[] poleCisel;//deklarace
Console.WriteLine("Zadej velikost pole: ");   
int velikost = int.Parse(Console.ReadLine()); //nacteni velikosti od uzivatele
poleCisel = new int[velikost]; //definice velikosti pole, ted je pole vytvoreno
//naplneni pole hodnotami
for (int i = 0; i < velikost; i++) {
    Console.WriteLine("Zadej hodnotu: ");
    poleCisel[i] = int.Parse(Console.ReadLine());
}

//vypsani pole hodnot
foreach (int pom in poleCisel) {
    Console.Write(pom + " ");
}
Console.WriteLine();
Console.WriteLine("Pomoci for cyklu: ");
//vypsani pomoci for cyklu
for (int i = 0; i < poleCisel.Length; i++) {
    Console.Write(poleCisel[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Pricteni hodnoty +5");
//ke kazdemu prvku pole pricteme 5
for (int i = 0; i < poleCisel.Length; i++) {
    poleCisel[i] = poleCisel[i] + 5;
}
foreach (int pom in poleCisel)
{
    Console.Write(pom + " ");
}


