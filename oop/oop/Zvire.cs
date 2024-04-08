using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Zvire
    {
private string druh;
private int vek;
        public Zvire() {
            this.druh = "";
            this.vek = 0;
        }
       
        public void setDruh(string nazev) { 
        this.druh = nazev;
        }
        public void setVek(int vek)
        {
            this.vek = vek;
        }

        public string getDruh()
        {
        return this.druh;
        }
        public int getVek()
        {
            return this.vek;
        }

        public void vydejZvuk(string zvuk) {
            Console.WriteLine(pripravZvuk(zvuk));
        }

        private string pripravZvuk(string zvuk) {
            string vysledny = zvuk + " " + zvuk;
            return vysledny;
        }
    }
}
