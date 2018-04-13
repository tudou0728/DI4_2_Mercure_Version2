using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class SousFamilles
    {
        private int Ref_Sous_Famille;
        private int Ref_Famille;
        private string Nom;

    
        public int Ref_Sous_Famille_Operation
        {
            get
            {
                return Ref_Sous_Famille;
            }

            set
            {
                Ref_Sous_Famille = value;
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

