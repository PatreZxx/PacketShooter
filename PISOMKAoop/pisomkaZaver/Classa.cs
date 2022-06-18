using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisomkaZaver
{
    internal class Classa
    {
        string ucitel;
        string meno;
        string trieda;
        string projekt;
        public Classa(string ucitel, string meno, string trieda, string projekt)
        {
            this.ucitel = ucitel;
            this.meno = meno;
            this.trieda = trieda;
            this.projekt = projekt;
        }
        public Classa(string ucitel, string projekt)
        {
            this.ucitel = ucitel;
            this.projekt = projekt;
        }
        public string Ucitel
        {
            get
            {
                return ucitel;
            } 
        }
        public string Meno
        {
            get
            {
                return meno;
            } 
        }
        public string Tieda
        {
            get
            {
                return trieda;
            } 
        }
        public string Projekt
        {
            get
            {
                return projekt;
            } 
        }
    }
}
