using System;

class MainClass
{
    public static void Main(string[] args)
    {

        bool[,] mapa =
        {
            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
        };

        Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
        Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
        Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

    }

    static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
    {
        int count = 0;
        //sem přijde váš kód
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                try
                {
                    if (mapa[sourY + i, sourX + j])
                        if (!(j == 0 && i == 0))
                            count++;
                }
                catch
                {
                    //break;
                }
            }
        }
        return count;
    }
}
