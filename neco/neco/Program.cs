//spojene metody matice + diagonala, proto to nefunguje
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Jak velkou chceš matici?");
        int velikost = int.Parse(Console.ReadLine());
        int[,] matice = new int[velikost, velikost];
        Console.WriteLine("Od kolika chceš generovat?");
        int dolnimez = int.Parse(Console.ReadLine());
        Console.WriteLine("Do kolika chceš generovat?");
        int hornimez = int.Parse(Console.ReadLine());
        matice = maticehodnot(velikost, dolnimez, hornimez);
        Console.WriteLine("Diagonala");
        int[] pole = polediagonala(matice);
        Console.WriteLine(pole.Length);
        for (int i = 0; i < pole.Length; i++)
        {
            Console.Write(" a");
        }
    }

    static int[,] maticehodnot(int velikost, int dolnimez, int hornimez)
    {
        int[,] matice = new int[velikost, velikost];
        Random generator = new Random();

        for (int i = 0; i < matice.GetLength(0); i++)
        {
            for (int j = 0; j < matice.GetLength(1); j++)
            {
                int cislo = generator.Next(dolnimez, hornimez + 1);
                Console.Write(cislo + " ");
                matice[i, j] = cislo;


            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("--------------------");
        return matice;
    }
    static int[] polediagonala(int[,] matice)
    {
        int[] pole = new int[matice.GetLength(0)];
        int index = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; i < 4; j++)
            {
                if (i == j)
                {
                    pole[index] = matice[i, j];
                    index++;
                    Console.WriteLine("ahoj");
                }
            }
        }

        return pole;
    }

}



