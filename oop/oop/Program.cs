using oop;

Zvire andulka = new Zvire();
andulka.setDruh("andulka");
andulka.setVek(3);
Console.WriteLine("Zvire je" + andulka.getDruh() + " a je ji " + andulka.getVek() + " let");
andulka.vydejZvuk("pip");
zoo dvur = new zoo("dvur");
dvur.pocetZvirat();
dvur.pridejZvire("pes", 4);
dvur.pocetZvirat();
