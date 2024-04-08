using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   class zoo
    {
        private string nazev;
        private List<Zvire> seznamZvirat = new List<Zvire>();
        public void setNazev(String nazev) { 
        this.nazev = nazev;
        }
        public string getNazev()
        {
            return this.nazev;
        }
        public zoo(string nazev)
        {
            this.nazev = nazev;
        }

        public void pridejZvire(string druh, int vek) {
            Zvire nove = new Zvire();
            nove.setDruh(druh);
            nove.setVek(vek);
            seznamZvirat.Add(nove);
        }

        public void pocetZvirat() {
            Console.WriteLine("Aktualne ma zoo " + seznamZvirat.Count + " zvirat.");
        }

        public List<Zvire> vratZvirata() { 
        return seznamZvirat;
        }

    }
}
