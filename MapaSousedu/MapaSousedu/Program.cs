using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool[,] mapa1 =
        {
            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
        };

        Vypis2DPole(Sousede(mapa1));
        Console.WriteLine();

        bool[,] mapa2 =
        {
            { true,  true,  false, false, true },
            { false, false, true,  true,  false },
            { false, false, false, true,  false },
        };

        Vypis2DPole(Sousede(mapa2));
    }

    //sem dejte kód metody Sousede, 
    //dle zadání která dostává 2D pole typu bool a vrací 2D pole typu int

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
    static int[,] Sousede(bool[,] mapa)
    {
        int[,] mapa2 = new int[mapa.GetLength(0), mapa.GetLength(1)];

        for (int i = 0; i < mapa.GetLength(0); i++)
        {
            for (int j = 0; j < mapa.GetLength(1); j++)
            {
                mapa2[i, j] = PocetSousedu(mapa, j, i);
            }
        }

        return mapa2;
    }
    //zde končí váš kód

    public static void Vypis2DPole(int[,] pole)
    {
        //do kódu této metody nezasahujte - nebo si můžete doplnit rámečky jako v jedné z předešlých úloh
        for (int y = 0; y < pole.GetLength(0); y++)
        {
            for (int x = 0; x < pole.GetLength(1); x++)
            {
                Console.Write(pole[y, x]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}