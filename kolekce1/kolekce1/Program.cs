int[] poleCisel = { 3, 4, 9, 7, 5 };
Console.WriteLine("Vypsane pole cele: ");
vypisPole(poleCisel);
int[] lichaCisla = vratLicha(poleCisel);
Console.WriteLine("Licha cisla: ");
vypisPole(lichaCisla);
static void vypisPole(int[] cisla) { 
for (int i=0;i<cisla.Length;i++)
    {
        if (cisla.Length == 0)
        {
            Console.WriteLine("Pole je prazdne.");
        }
        else
        {
            if (i < cisla.Length - 1)
                Console.Write(cisla[i] + ", ");
            else
                Console.Write(cisla[i]);
        }
    }

}

static int[] vratLicha(int[] cisla)
{
    List<int> seznamLicha = new List<int>();
    for (int i = 0; i < cisla.Length; i++) {
        if (cisla[i] % 2 != 0) {
            seznamLicha.Add(cisla[i]);
        }
    }
   
        return seznamLicha.ToArray();


}
