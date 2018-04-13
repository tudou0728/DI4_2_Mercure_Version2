using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.dao;
using Mercure.Model;
using System;

namespace Mercure.controleur
{
    class AjouterControleur
    {
        private ArticlesDAO ArticleDao=new ArticlesDAO();
        private FamillesDAO FamilleDao = new FamillesDAO();
        private MarquesDAO MarqueDao = new MarquesDAO();
        private SousFamillesDAO SousFamilleDao = new SousFamillesDAO();

        public bool AjouterArticle(string Description,string RefArticle,string Marque,string Famille,string SousFamille,string PrixHT,int Quantite)
        {
            int RefMarque = 0;
            int RefFamille = 0;
            int RefSousFamille = 0;
            List<Marques> MarqueListe=MarqueDao.GetMarquesParNom(Marque);
            if (MarqueListe == null || MarqueListe.Count == 0)
            {
                int CountM = MarqueDao.GetAll().Count;
                MarqueDao.Ajouter_Marque(CountM + 1, Marque);
                RefMarque = CountM + 1;
            }
            else
            {
                RefMarque = MarqueListe[0].Ref_Marque_Operation;
            }
            List<Familles> FamilleListe = FamilleDao.Rechercher_Famille_Par_Nom(Famille);
            if (FamilleListe == null || FamilleListe.Count == 0)
            {
                int CountF = FamilleDao.GetAll().Count;
                FamilleDao.Ajouter_Famille(CountF + 1, Famille);
                RefFamille = CountF + 1;
            }
            else
            {
                RefFamille = FamilleListe[0].Ref_Famille_Operation;
            }
            int Count2 = SousFamilleDao.GetAll().Count;
            RefSousFamille = AjouterSousFamille(Count2 + 1, SousFamille, Famille);
            float Prix=float.Parse(PrixHT.Replace(',','.'));          
            ArticleDao.Ajouter_Artcle(RefArticle,Description,RefSousFamille,RefMarque,Quantite,Prix);
            return true;
        }

        public int Integration(List<List<string>> Liste)
        { 
          int I=0;
          int Count = 0;
          for (I = 0; I < Liste.Count; I++)
          { 
              List<string> Article=Liste[I];
              string Description = Article[0];
              string RefArticle = Article[1];
              string Marque = Article[2];
              string Famille = Article[3];
              string SousFamille = Article[4];
              string PrixHT = Article[5];
              if (AjouterArticle(Description, RefArticle, Marque, Famille, SousFamille, PrixHT,0))
              {
                  Count++;
              }
          }
          return Count;
        }

        public int AjouterSousFamille(int Id,string SousFamille,string Famille)
        {
            int RefSousFamille = 0;
            List<SousFamilles> SousFamilleListe = SousFamilleDao.GetSousFamillesParNom(SousFamille);
            if (SousFamilleListe == null || SousFamilleListe.Count == 0)
            {
                int Id_Famille;
                List<Familles> FamilleListe2 = FamilleDao.Rechercher_Famille_Par_Nom(Famille);
                if (FamilleListe2 == null || FamilleListe2.Count == 0)
                {
                    int CountF = FamilleDao.GetAll().Count;
                    FamilleDao.Ajouter_Famille(CountF + 1, Famille);
                    Id_Famille = CountF + 1;
                }
                else
                {
                    Id_Famille = FamilleListe2[0].Ref_Famille_Operation;
                }
                SousFamilleDao.Ajouter_Sous_Familles(Id, Id_Famille, SousFamille);
                RefSousFamille = Id;
            }
            else
            {
                RefSousFamille = SousFamilleListe[0].Ref_Sous_Famille_Operation;
            }
            return RefSousFamille;
        }
    }
}

//猪不能收集数据