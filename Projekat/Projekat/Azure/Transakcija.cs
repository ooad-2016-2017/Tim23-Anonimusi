using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Azure
{
    class Transakcija
    {
        public string id
        {
            get;
            set;
        }
        public string sifraRezervacije
        {
            get;
            set;
        }
        public Int32 brojKarata
        {
            get;
            set;
        }
        public Int32 cijena
        {
            get;
            set;
        }
    }
}
