using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace soubory
{
    internal class Student
    {
        private String jmeno;
        private String prijmeni;
        public void setJmeno(String jmeno)
        {
            this.jmeno = jmeno;
        }
        public void setPrijmeni(String prijmeni)
        {
            this.prijmeni = prijmeni;
        }
        public String getJmeno() {

            return this.jmeno;
        }
        public String getPrijmeni()
        {

            return this.prijmeni;
        }

        public Student(string jmeno, string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return "Student: " + this.jmeno + " " + this.prijmeni;
        }
    }
}
