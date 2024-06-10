using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soubory
{
    internal class Trida
    {
        private List<Student> studenti;


        public Trida()
        {
            studenti = new List<Student>();
        }

        public void PridejStudenta(String jm, String pr)
        {
            Student novy = new Student(jm, pr);
            studenti.Add(novy);
        }

      

        public void UlozTridu(String nazev)
        {
            StreamWriter sw = new StreamWriter(nazev + ".txt");
            //pokud pouzijete jako druhy parametr slovo true, bude se text pridavat
            sw.WriteLine("Seznam studentu:");
            foreach (Student student in studenti)
            {
                sw.WriteLine(student.ToString());
            }
            sw.Flush();
            sw.Close();

        }

        public void nactiTridu(String nazev) {
            StreamReader sr = new StreamReader(nazev + ".txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        
        }
    }
}
