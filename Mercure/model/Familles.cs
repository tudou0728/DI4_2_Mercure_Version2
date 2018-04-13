using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Familles
    {
        private int Ref_Famille;
        private string Nom;

     
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
        public int Ref_Famille_Operation
        {
            get
            {
                return Ref_Famille;
            }

            set
            {
                Ref_Famille = value;
            }
        }
    }
}

