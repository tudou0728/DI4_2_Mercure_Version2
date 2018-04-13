using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mercure.controleur
{
    class FichierControleur
    {
        public  List<List<string>> Lire_Fichier(string Fichier_Nom)//,SQLiteConnection BD
        {
            XmlDocument Lire_Fichier = new XmlDocument();
            Lire_Fichier.Load(Fichier_Nom);

            List<List<string>> Resultat = new List<List<string>>();

            XmlElement root = Lire_Fichier.DocumentElement;
            XmlNodeList Node_Liste = root.GetElementsByTagName("article");
            foreach (XmlNode node in Node_Liste)
            {
                List<string> Article=new List<string>();
                string Description = ((XmlElement)node).GetElementsByTagName("description")[0].InnerText;
                Article.Add(Description);
                string RefArticle = ((XmlElement)node).GetElementsByTagName("refArticle")[0].InnerText;
                Article.Add(RefArticle);
                string Marque = ((XmlElement)node).GetElementsByTagName("marque")[0].InnerText;
                Article.Add(Marque);
                string Famille = ((XmlElement)node).GetElementsByTagName("famille")[0].InnerText;
                Article.Add(Famille);
                string SousFamille = ((XmlElement)node).GetElementsByTagName("sousFamille")[0].InnerText;
                Article.Add(SousFamille);
                string PrixHT = ((XmlElement)node).GetElementsByTagName("prixHT")[0].InnerText;
                Article.Add(PrixHT);
                Resultat.Add(Article);
                //Console.WriteLine(Description + " " + RefArticle + " " + Marque + " " + Famille1 + " " + SousFamille + " " + PrixHT);
            }
            return Resultat;
        }
    }
}
