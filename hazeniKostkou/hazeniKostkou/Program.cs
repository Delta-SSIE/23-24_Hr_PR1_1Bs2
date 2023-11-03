// See https://aka.ms/new-console-template for more information
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //tohle jsou promenne shodne pro cely beh programu
        Random hodKostky = new Random();
        int pocet;
        int hodnota;
        //tady uz resim samotne uzivatelske rozhodnuti
        String rozhodnuti = "A";
        while (rozhodnuti == "A" || rozhodnuti == "a")
        { //resim obe varianty vlozeni, alternativa funkce upper nebo lower
          //pro kazdy novy beh musime "vynulovat" nase hodnoty, aby byly pokusy nezavisle
            pocet = 1;
            hodnota = hodKostky.Next(1, 7);
            //samotne hazeni kostkou a pocitani pokusu
            while (hodnota != 6)
            {
                hodnota = hodKostky.Next(1, 7);
                pocet++; //stejne jako pocet = pocet+1      
            }
            Console.WriteLine("6 padla na " + pocet + " pokusu.");
            //pro dalsi beh, musime znovu nacist promennou na rozhodnuti
            Console.WriteLine("Chcete pokracovat? A/N");
            rozhodnuti = Console.ReadLine();
        }
    }
    /*
     * -- level 2
     class MainClass {
  public static void Main (string[] args) {
    //tohle jsou promenne shodne pro cely beh programu
Random hodKostky = new Random();
    int pocetOpakovani = 0;
    int pocet;
    int hodnota;
    int soucetHodu = 0;
    int maxPocetHodu = 1;
    //tady uz resim samotne uzivatelske rozhodnuti
    String rozhodnuti = "A";
    while (rozhodnuti=="A" || rozhodnuti=="a"){ //resim obe varianty vlozeni, alternativa funkce upper nebo lower
      //pro kazdy novy beh musime "vynulovat" nase hodnoty, aby byly pokusy nezavisle
      pocetOpakovani++;
    pocet = 1;
    hodnota = hodKostky.Next(1,7);
      //samotne hazeni kostkou a pocitani pokusu
    while (hodnota != 6){
hodnota = hodKostky.Next(1,7);
      pocet++; //stejne jako pocet = pocet+1      
    }
Console.WriteLine("6 padla na " + pocet + " pokusu.");
     if(pocet>maxPocetHodu)
      maxPocetHodu = pocet;
      //pro dalsi beh, musime znovu nacist promennou na rozhodnuti
      soucetHodu = soucetHodu + pocet;
  Console.WriteLine("Chcete pokracovat? A/N");
      rozhodnuti = Console.ReadLine();
  }
    Console.WriteLine("Pocet opakovani behu programu byl " + pocetOpakovani);
    Console.WriteLine("Soucet vsech hodu byl " + soucetHodu);
    Console.WriteLine("Prumerny pocet hodu na pokus je: " + soucetHodu/pocetOpakovani);
    Console.WriteLine("Maximalni pocet hodu byl " + maxPocetHodu);
    }
}
     */
}
