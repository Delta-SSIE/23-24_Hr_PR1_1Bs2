// See https://aka.ms/new-console-template for more information
Console.WriteLine("Analyzator hesel 1.0");
//string text = "Heslo123ABC";
int pocetVelka = 0;
int pocetMala = 0;
int pocetCisla = 0;
int limitVelka = 4;
int limitMala = 3; 
int limitCisla = 2;
bool splneno = false;

while (splneno == false)
{
    Console.WriteLine("Zadej text");
    String text = Console.ReadLine();

    Console.WriteLine("Analyzovany text: " + text);
   
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] >= 65 && text[i] <= 90)//velka pismena
        {
            pocetVelka++;
        }
        if (text[i] >= 97 && text[i] <= 122)//mala pismena
        {
            pocetMala++;
        }
        if (text[i] >= 48 && text[i] <= 57)//cislice
        {
            pocetCisla++;
        }
    }
    if (pocetVelka == limitVelka && pocetMala == limitMala && pocetCisla == limitCisla)
    {
        splneno = true;
    }
    else {
        Console.WriteLine("Text nesplnil pozadavky.");
      
        pocetCisla = 0;
        pocetMala = 0;
        pocetVelka = 0;
    }

}
Console.WriteLine("Text zadan spravne!");
Console.WriteLine("Vysledky analyzy: ");
Console.WriteLine("Pocet velkych pismen: " + pocetVelka);
Console.WriteLine("Pocet malych pismen: " + pocetMala);
Console.WriteLine("Pocet cisel: " + pocetCisla);

