// See https://aka.ms/new-console-template for more information
/*string rozhodnuti = "a";
int cislo,cislo2,soucet;
//Console.WriteLine("Chcete pokracovat? a/n");
//rozhodnuti = Console.ReadLine();

while (rozhodnuti == "a")
{
    Console.WriteLine("Zadej cislo A");
    cislo = int.Parse(Console.ReadLine());
    Console.WriteLine("Zadej cislo B");
    cislo2 = int.Parse(Console.ReadLine());
    soucet = cislo + cislo2;
    Console.WriteLine("Vysledek je: " + soucet);

    Console.WriteLine("Chcete pokracovat? a/n");
    rozhodnuti = Console.ReadLine();
}*/

//mala nasobilka - nacteme hodnotu a vypiseme nasobky do cislo*10
/*Console.WriteLine("Mala nasobilka");
Console.WriteLine("Zadej hodnotu zakladu: ");
int cislo = int.Parse(Console.ReadLine());
int nasobek = 0;
Console.WriteLine("Tady je vystup: ");
while (nasobek <= 10) {
    Console.WriteLine(cislo*nasobek);

    //nasobek = nasobek + 1;
    nasobek++; //inkrementace +1, dekrementace -1
}
*/
Console.WriteLine("Mala nasobilka");
int zaklad = 1;
int nasobek = 1;
int pom = 0;
Console.WriteLine("Tady je vystup: ");
while (zaklad <= 10)
{
    while (nasobek <= 10)
    {
        pom = zaklad * nasobek;
        Console.Write(pom + ",");
        nasobek++;
    }
    Console.WriteLine();
    nasobek = 1;
    zaklad++;
}
