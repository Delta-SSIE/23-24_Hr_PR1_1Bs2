using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodejce_klimatizaci
{
    internal class Klimatizace
    {
        private String typ;
        private int cena;
        private String druh;
        private String montaz;

    
        public Klimatizace(String typ, int cena, String druh) {
            this.typ = typ;
            this.cena = cena;
            this.druh = druh;
        }

        public void setTyp(String typ) { 
        this.typ = typ;
        }

        public String getTyp() { 
            return this.typ;
        }
        public void setDruh(String druh)
        {
            this.Druh = druh;
        }
        public String getDruh()
        {
            return this.Druh;
        }
        public void setCena(int cena)
        {
            this.cena = cena;
        }
      public int getCena()
        {
            return this.cena;
        }

        public void setMontaz(String montaz)
        {
            this.montaz = montaz;
        }
        public string getMontaz() {
            return this.montaz;
        }

    }
}
