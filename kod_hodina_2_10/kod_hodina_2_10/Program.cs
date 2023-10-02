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

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej rok narozeni: ");
        int rokNarozeni = int.Parse(Console.ReadLine());
        int nastupDuchod = 0;

        /*switch (rokNarozeni){
        case 1936:
        case 1937:
        case 1938:
        case 1939:
          nastupDuchod = 60;
          break;


        }
        */
        if (rokNarozeni >= 1936 && rokNarozeni <= 1940)
            nastupDuchod = 60;
        if (rokNarozeni >= 1941 && rokNarozeni <= 1946)
            nastupDuchod = 61;
        if (rokNarozeni >= 1947 && rokNarozeni <= 1952)
            nastupDuchod = 62;
        if (rokNarozeni >= 1953 && rokNarozeni <= 1958)
            nastupDuchod = 63;
        if (rokNarozeni >= 1959 && rokNarozeni <= 1964)
            nastupDuchod = 64;
        if (rokNarozeni >= 1965 && rokNarozeni <= 1970)
            nastupDuchod = 65;
        if (rokNarozeni >= 1971 && rokNarozeni <= 1976)
            nastupDuchod = 66;
        if (rokNarozeni >= 1977 && rokNarozeni <= 1982)
            nastupDuchod = 67;
        if (rokNarozeni >= 1983 && rokNarozeni <= 1988)
            nastupDuchod = 68;
        if (rokNarozeni >= 1989 && rokNarozeni <= 1994)
            nastupDuchod = 69;
        if (rokNarozeni >= 1995 && rokNarozeni <= 2000)
            nastupDuchod = 70;
        if (rokNarozeni >= 2001 && rokNarozeni <= 2005)
            nastupDuchod = 71;
        Console.WriteLine("S rokem narozeni " + rokNarozeni + " pujdes do duchodu v " + nastupDuchod + " letech a bude to v roce " + (rokNarozeni + nastupDuchod));
    }
}
