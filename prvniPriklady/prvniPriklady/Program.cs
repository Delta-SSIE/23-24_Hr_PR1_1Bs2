internal class Program
{
    private static void Main(string[] args)
    {
        int vysledek;
        Console.WriteLine("Zadej mi hodnotu pro znasobeni");
        int cislo = int.Parse(Console.ReadLine());
        vysledek = cislo * 2;

        Console.WriteLine("Zdvojnasobene cislo je " + vysledek);
    }
}