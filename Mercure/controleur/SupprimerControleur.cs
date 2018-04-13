using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.dao;
using Mercure.Model;

namespace Mercure.controleur
{
    class SupprimerControleur
    {
        private ArticlesDAO ArticleDao = new ArticlesDAO();
        private FamillesDAO FamilleDao = new FamillesDAO();
        private MarquesDAO MarqueDao = new MarquesDAO();
        private SousFamillesDAO SousFamilleDao = new SousFamillesDAO();

        public void SupprimerTous()
        {
            FamilleDao.SupprimerTous();
            MarqueDao.SupprimerTous();
            SousFamilleDao.SupprimerTous();
            ArticleDao.SupprimerTous();
        }
    }
}
