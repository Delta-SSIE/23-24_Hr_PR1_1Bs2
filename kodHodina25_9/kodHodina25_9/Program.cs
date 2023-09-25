internal class Program
{
    private static void Main(string[] args)
    {
        /* int cislo;
         double vysledek;
         Console.WriteLine("Zadej cislo pro odmocninu: ");
         cislo = int.Parse(Console.ReadLine());
         if (cislo >= 0)
         {
             vysledek = Math.Sqrt(cislo);
             Console.WriteLine("Odmocnina je: " + vysledek);
         }
         else
         {
             Console.WriteLine("Cislo nelze odmocnit");
         }
         Console.WriteLine("Tady pokracuje program.");


        8*/

        /*  int a = 0;
          Console.WriteLine("Puvodni hodnota: " + a);
          if (a == 0)
              a = 1;
          else
          {
              if (a == 1)
                  a = 0;
          }
          Console.WriteLine("Nova hodnota: " + a);
        */

        //uzivatel zada cislo a my hodnotime, zda je cislo v rozsahu 1-10 a zaroven sude
        Console.WriteLine("Zadej hodnotu: ");
        int cislo2 = 5 / 2;
        int cislo3 = 5 % 2;
        Console.WriteLine("Cislo2 " + cislo2);
        Console.WriteLine("Cislo3 " + cislo3);
        int cislo = int.Parse(Console.ReadLine());
        Console.WriteLine("Cislo2 " + cislo2);

        if (((cislo >= 1) && (cislo <= 10)) && (cislo%2==0) )
            Console.WriteLine("Cislo je v danem rozsahu 1-10");
        else
            Console.WriteLine("Cislo neni v danem rozsahu 1-10");
    }
}