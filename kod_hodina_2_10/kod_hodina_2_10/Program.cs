using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int denTydne;
        Console.WriteLine("Zadej cislo dne: ");
        denTydne = int.Parse(Console.ReadLine());
        switch (denTydne)
        {
            case 1:
                Console.WriteLine("den je pondeli");
                break;
            case 2:
                Console.WriteLine("den je utery");
                break;
            case 3:
                Console.WriteLine("den je streda");
                break;
            case 4:
                Console.WriteLine("den je ctvrtek");
                break;
            case 5:
                Console.WriteLine("den je patek");
                break;
            case 6:
                Console.WriteLine("den je sobota");
                break;
            case 7:
                Console.WriteLine("den je nedele");
                break;
            default:
                Console.WriteLine("zadany den je neplatny");
                break;

        }


    }
}
