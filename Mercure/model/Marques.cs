using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Marques
    {
        private int Ref_Marque;
        private string Nom;

        public int Ref_Marque_Operation
        {
            get
            {
                return Ref_Marque;
            }

            set
            {
                Ref_Marque = value;
            }
        }

        public string Nom_Operation
        {
            get
            {
                return Nom;
            }

            set
            {
                Nom = value;
            }
        }
    }
}

