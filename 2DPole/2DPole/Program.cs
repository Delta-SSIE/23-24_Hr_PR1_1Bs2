// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int[,] Pole2D;  //deklarace matice, lze i int [][], pak se ale musi pouzivat vsude stejne
Pole2D = new int[4,4]; //definice matice o rozmeru 4x4
//int[,] Pole2D2 = new int[3,3]; //tuhle matici, chceme naplnit rucne od uzivatele
int[,] maticeDefinice = new int[,] { { 3, 4, 5 }, { 4, 5, 6 }, { 7, 8, 9 } };


//naplneni matice nahodnymi hodnotami
naplnMatici(Pole2D, 1, 10); //generujeme cisla 1-9
vypisMatici(Pole2D);

Console.WriteLine("-------------------------------");

vypisMatici(maticeDefinice);

//naplnMaticiRucne(Pole2D2);
//vypisMatici(Pole2D2);

Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");
Console.WriteLine("Hlavni diagonala:");
vypisDiagonaluHlavniBezPole(Pole2D); //vraci hlavni diagonalu pouze jako vypis
int[] poleVraceno = diagonalaHlavniPole(Pole2D);//nesmim zapomenout, ze metoda vraci cele pole
Console.WriteLine("Diagonala v poli");
Console.WriteLine();
for(int i = 0;i<poleVraceno.Length;i++ )
{
    Console.Write(poleVraceno[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Prvky nad hlavni diagonalou: ");
vypisNadHlavniDiagonalou(Pole2D);
Console.WriteLine();
Console.WriteLine("Prvky pod hlavni diagonalou: ");
vypisPodHlavniDiagonalou(Pole2D);






static int[,] naplnMatici(int[,] matice, int dolniMez, int horniMez) {
    Random generator = new Random();
    for (int i = 0; i < matice.GetLength(0); i++)//projizdim radky
    {
        for (int j = 0; j < matice.GetLength(1); j++)
        { //projizdim sloupce
            matice[i, j] = generator.Next(dolniMez, horniMez); //budu generovat nahodna cisla
        }
    }
    return matice;
}

int[,] naplnMaticiRucne(int[,] matice)
{
    for (int i = 0; i < matice.GetLength(0); i++) {
        for (int j = 0; j < matice.GetLength(1); j++) {
            Console.WriteLine("Zadej hodnotu:");

            while (int.TryParse(Console.ReadLine(), out matice[i, j]) == false) {
                Console.WriteLine("Neplatna hodnota"); //dokud se nepovede nacist vstup jako cislo, bude uzivatele upozornovat
           }
                
        }
    }
    return matice;
}





static void vypisMatici(int[,] matice) {
    for (int i = 0; i < matice.GetLength(0); i++)//projedu radky
    {
        for (int j = 0; j < matice.GetLength(1); j++)//na kazdem radku projedu sloupce
        {
            Console.Write(matice[i, j] + " ");   //na radek vypisuji za sebou         
        }
        Console.WriteLine(); //po kazdem radku odradkuji
    }
}

static void vypisDiagonaluHlavniBezPole(int[,] matice) {
    for (int i = 0; i < matice.GetLength(0);i++) { //projdu řádky
        for (int j = 0; j < matice.GetLength(1); j++) { //projdu sloupce
        if(i == j) //podminka hlavni diagonaly
            {
                Console.Write(matice[i, j] + " ");
            }
        }
    }
}

static int[] diagonalaHlavniPole (int[,] matice)
{
    int[] pole = new int[matice.GetLength(0)]; //vzdycky bude mit rozmer jako je velikost ctvercove matice
    for (int i = 0; i < matice.GetLength(0); i++)
    {
        pole[i] = matice[i, i];
    }
    
    return pole;

}

static void vypisNadHlavniDiagonalou(int[,] matice) {
    for (int i = 0; i < matice.GetLength(0); i++)
    {
        for (int j = 0; j < matice.GetLength(1); j++)
        {
            if (i < j) { //podminka pro prvky nad hlavni diagonalou
                Console.Write(matice[i, j] + " ");
            }
        }
    }


}

static void vypisPodHlavniDiagonalou(int[,] matice)
{
    for (int i = 0; i < matice.GetLength(0); i++)
    {
        for (int j = 0; j < matice.GetLength(1); j++)
        {
            if (i > j)
            { //podminka pro prvky pod hlavni diagonalou
                Console.Write(matice[i, j] + " ");
            }
        }
    }


}

