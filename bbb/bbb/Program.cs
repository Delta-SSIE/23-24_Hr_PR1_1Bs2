int[,] matice = new int[5, 5];
matice = naplnMatici(1, 10);  
vypisMatici(matice);
vypisHlavniDiagonalu(matice);


static int[,] naplnMatici(int dolniMez, int horniMez)
{
    int[,] vysledek = new int[5, 5];
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    { //radky
        for (int j = 0; j < 5; j++)//sloupce
        {
            vysledek[i, j] = random.Next(dolniMez, horniMez);
        }
    }
    return vysledek;
}

static void vypisMatici(int[,] maticeKVypsani) {
    for (int i = 0; i < 5; i++)
    { //radky
        for (int j = 0; j < 5; j++)//sloupce
        {
            Console.Write(maticeKVypsani[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void vypisHlavniDiagonalu(int[,] maticeKVypsani) {
    for (int i = 0; i < maticeKVypsani.GetLength(0); i++)
    { 
        for (int j = maticeKVypsani.GetLength(1)-1; j >= 0 ; j--)
        {
            
                Console.Write(maticeKVypsani[i, j] + " ");
             
        }
      
    }
}