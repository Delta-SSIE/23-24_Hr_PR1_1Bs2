// See https://aka.ms/new-console-template for more information
String pozice;
Console.WriteLine("Program sachovnice.");
Console.WriteLine("Zadej pozici veze na sachovnici:");
String vez = Console.ReadLine();
//vytahnu si ze vstupu pozici a rozdelim si ji na radek a sloupec
string radek = vez[0].ToString();
char pom = vez[1];
//int sloupec = pom - '0';
int sloupec2 = int.Parse(pom.ToString());
Console.WriteLine("Rozebrane souradnice jsou " + radek + " " + sloupec2);

/* vypsani pozic v cele sachovnici
for (int i = 0; i < 8; i++) { //radek
    pozice = ((char)('A' + i)).ToString(); //A,B,C, ...
for (int j = 1; j < 9; j++) //sloupec
    {
        Console.Write(pozice + j + " ");
    }
Console.WriteLine();
}
*/
//nejprve vypsani radku
for (int i = 1; i < 9; i++)
{ //radek
    if (i != sloupec2)
    {
        pozice = radek + i;
        Console.Write(pozice + " ");
    }
}
Console.WriteLine("");
for (char i = 'A'; i < 'I'; i++) {
    if(i.ToString() != radek)
   Console.Write(i.ToString() + pom.ToString() + " ");
}