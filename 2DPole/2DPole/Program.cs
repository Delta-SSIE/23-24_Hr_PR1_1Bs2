// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int[,] Pole2D;  //deklarace matice, lze i int [][], pak se ale musi pouzivat vsude stejne
Pole2D = new int[4,4]; //definice matice o rozmeru 4x4
int[,] Pole2D2 = new int[3,3]; //tuhle matici, chceme naplnit rucne od uzivatele


//naplneni matice nahodnymi hodnotami
naplnMatici(Pole2D, 1, 10); //generujeme cisla 1-9
vypisMatici(Pole2D);

Console.WriteLine("-------------------------------");

naplnMaticiRucne(Pole2D2);
vypisMatici(Pole2D2);






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

