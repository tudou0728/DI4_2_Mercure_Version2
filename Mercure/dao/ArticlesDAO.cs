using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Mercure.Model;
using System.Data;
using Mercure.controleur;


namespace Mercure.dao
{
    class ArticlesDAO
    {
        public void Ajouter_Artcle(string Ref_Article, string Description, int Ref_Sous_Famille, int Ref_Marque, int Quantite, float PrixTH)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            if (Rechercher_Articles(Ref_Article) ==null|| Rechercher_Articles(Ref_Article).Count == 0)
            {
                string Sql = "insert into Articles Values(@Ref_Article,@Description,@Ref_Sous_Famille,@Ref_Marque,@PrixTH,@Quantite)";
                SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
                Cmd.CommandText = Sql;
                Cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
                Cmd.Parameters.AddWithValue("@Description", Description);
                Cmd.Parameters.AddWithValue("@Ref_Sous_Famille", Ref_Sous_Famille);
                Cmd.Parameters.AddWithValue("@Ref_Marque", Ref_Marque);
                Cmd.Parameters.AddWithValue("@PrixTH", PrixTH);
                Cmd.Parameters.AddWithValue("@Quantite", Quantite);
                Cmd.ExecuteNonQuery();
            }           
        }

        public void Supprimer_Article(string Ref_Article)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "delete from Articles where RefArticle = @Ref_Article";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.CommandText = Sql;
            Cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
            Cmd.ExecuteNonQuery();
        }

        public void Modifier_Article(string Ref_Article, string Description, int Ref_Sous_Famille, int Ref_Marque, int Quantite, float PrixTH)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "update Articles set  Description = @Description, RefSousFamille = @Ref_Sous_Famille, RefMarque = @Ref_Marque, Quantite= @Quantite, PrixHT = @PrixTH where RefArticle= @Ref_Article ";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
            Cmd.Parameters.AddWithValue("@Description", Description);
            Cmd.Parameters.AddWithValue("@Ref_Sous_Famille", Ref_Sous_Famille);
            Cmd.Parameters.AddWithValue("@Ref_Marque", Ref_Marque);
            Cmd.Parameters.AddWithValue("@PrixTH", PrixTH);
            Cmd.Parameters.AddWithValue("@Quantite", Quantite);
            Cmd.ExecuteNonQuery();
        }

        public List<Articles> Rechercher_Articles(string Ref_Article)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Articles where RefArticle = @Ref_Article";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.CommandText = Sql;
            Cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
            Cmd.ExecuteNonQuery();
            List<Articles> List = new List<Articles>();
            SQLiteDataReader Reader = Cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    string Ref_Article1 = Reader["RefArticle"].ToString();
                    string Description = Reader["Description"].ToString();
                    int Ref_Sous_Famille = (int)Reader["RefSousFamille"];
                    int Ref_Marque = (int)Reader["RefMarque"];
                    int Quantite = (int)Reader["Quantite"];
                    float PrixTH = float.Parse(Reader["PrixHT"].ToString());

                    Articles Article = new Articles();
                    Article.Ref_Article_Operation = Ref_Article1;
                    Article.Description_Operation = Description;
                    Article.Ref_Sous_Famille_Operation = Ref_Sous_Famille;
                    Article.Ref_Marque_Operation = Ref_Marque;
                    Article.Quantite_Operation = Quantite;
                    Article.PrixTH_Operation = PrixTH;
                    List.Add(Article);
                }
            }
            return List;
        }

        public int SupprimerTous()
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "delete from Articles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            return Commande.ExecuteNonQuery();
        }

        public List<Articles> GetAll()
        {
            List<Articles> Resultats = new List<Articles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Articles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Articles Article = new Articles();
                    Article.Ref_Article_Operation = Reader["RefArticle"].ToString();
                    Article.Description_Operation = Reader["Description"].ToString();
                    Article.Ref_Sous_Famille_Operation = (int)Reader["RefSousFamille"];
                    Article.Ref_Marque_Operation = (int)Reader["RefMarque"];
                    Article.Quantite_Operation = (int)Reader["Quantite"];
                    Article.PrixTH_Operation = float.Parse(Reader["PrixHT"].ToString());
                    Resultats.Add(Article);
                }
            }
            return Resultats;
        }
    }
}
