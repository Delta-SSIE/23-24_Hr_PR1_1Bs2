using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodejce_klimatizaci
{
    internal class Prodejce
    {
        private String nazev;
        private String sidlo;
        private String telefon;
        private int pocet_zam;
        private String email;
        List<Klimatizace> nabidka;

        public Prodejce(String nazev, String sidlo, String telefon) { 
        this.nazev = nazev;
            this.sidlo = sidlo;
            this.telefon = telefon;
            this.pocet_zam = 0;
            this.email = "";
            this.nabidka = new List<Klimatizace>();
        }
        public void SetNazev(String str) {
            this.nazev = str;
        }
        public void SetSidlo(String str)
        {
            this.sidlo = str;
        }
        public void SetTelefon(String str)
        {
            this.telefon = str;
        }
        public void Setpocet_zam(int str)
        {
            this.pocet_zam = str;
        }
        public void SetEmail(String str)
        {
            this.email = str;
        }

        public String GetNazev() { return this.nazev; }
        public String getSidlo() { return this.sidlo; }
        public String getTelefon() { return this.telefon; }
        public String getEmail() { return this.email; }
        public int getPocet_zam() {return this.pocet_zam; }

        public void pridejKlimatizaci(String typ, int cena, String druh) {
            Klimatizace nova = new Klimatizace(typ, cena, druh);
            nabidka.Add(nova);
        }
        public void odeberKlimatizaci(Klimatizace odebrani) {
            if (nabidka.Contains(odebrani) == false)
            {
                Console.WriteLine("Nenalezeno");
            }
            else
                nabidka.Remove(odebrani);
        }
    }
}
