// See https://aka.ms/new-console-template for more information
using soubory;

Trida prvak = new Trida();
prvak.PridejStudenta("Karel", "Opicka");
prvak.PridejStudenta("Kluk", "Opicak");
prvak.UlozTridu("prvak");
prvak.nactiTridu("prvak");
Console.WriteLine(prvak.ToString());
Student opicka = new Student("Karel", "Opicka");
Console.WriteLine($"{opicka.ToString()}");
