using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Articles
    {
        private string Ref_Article;
        private string Description;
        private int Ref_Sous_Famille;
        private int Ref_Marque;
        private int Quantite;
        private float PrixTH;

       
        public string Ref_Article_Operation
        {
            get
            {
                return Ref_Article;
            }

            set
            {
                Ref_Article = value;
            }
        }

  
        public string Description_Operation
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }

     
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

     
        public int Quantite_Operation
        {
            get
            {
                return Quantite;
            }

            set
            {
                Quantite = value;
            }
        }

     
        public float PrixTH_Operation
        {
            get
            {
                return PrixTH;
            }

            set
            {
                PrixTH = value;
            }
        }
    }
}

