using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] A = { -1, 2 };
        int[] rozmery = { 2, 3 };
        int posunX = 2;
        int posunY = 3;
        int[] B = { A[0] + posunX, A[1] };
        int[] C = { A[0], A[1] + posunY };
        int[] D = { A[0] + posunX, A[1] + posunY };
        Console.Write("{ ");
        foreach (int i in A)
        {
            Console.Write(i.ToString() + " ");
        }
        Console.Write("}\n");
        Console.Write("{ ");

        foreach (int i in B)
        {
            Console.Write(i.ToString() + " ");
        }
        Console.Write("}\n");
        Console.Write("{ ");

        foreach (int i in C)
        {
            Console.Write(i.ToString() + " ");

        }
        Console.Write("}\n");

        Console.Write("{ ");

        foreach (int i in D)
        {
            Console.Write(i.ToString() + " ");

        }
        Console.Write("}");

    }
}
