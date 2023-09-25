// See https://aka.ms/new-console-template for more information
Console.WriteLine("Jsem program, co Ti spocita druhou odmocninu");
Console.WriteLine("Zadej cislo pro odmocneni: ");
int cislo = int.Parse(Console.ReadLine());
double odmocnina = 0;
if (cislo >= 0)
{
  odmocnina = Math.Sqrt(cislo);
    Console.WriteLine("Odmocnina z cisla " + cislo + " je " + odmocnina);
}
else
{
    Console.WriteLine("Cislo nelze odmocnit.");
}

