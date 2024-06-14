using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soubory
{
    internal class Skola
    {
        String nazev;
        public void nactiTridu(Trida t, String nazev) {
            StreamReader sr = new StreamReader(nazev + ".txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
                t.PridejStudenta(s,"");
            }
            sr.Close();
            Console.WriteLine("Nova trida nactena.");
            t.vypisTridu();
            

        }
    }
}
