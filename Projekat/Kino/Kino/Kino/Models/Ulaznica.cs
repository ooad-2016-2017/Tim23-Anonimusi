using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model
{
    public class Ulaznica
    {
        private int idUlaznice;
        private int idProjekcije;
        private int idSale;
        private int sjediste;

        public int IdUlaznice
        {
            get
            {
                return idUlaznice;
            }

            set
            {
                idUlaznice = value;
            }
        }

        public int IdProjekcije
        {
            get
            {
                return idProjekcije;
            }

            set
            {
                idProjekcije = value;
            }
        }

        public int IdSale
        {
            get
            {
                return idSale;
            }

            set
            {
                idSale = value;
            }
        }

        public int Sjediste
        {
            get
            {
                return sjediste;
            }

            set
            {
                sjediste = value;
            }
        }
    }
}
