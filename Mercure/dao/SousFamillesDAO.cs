using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Model;
using System.Data.SQLite;
using Mercure.controleur;

namespace Mercure.dao
{
    class SousFamillesDAO
    {
        public bool VerifierSousFamilles(int Id)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from SousFamilles where SousFamilles.RefSousFamille= @Id";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Id", Id);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            return Reader.HasRows;
        }

        //添加一个通过famille找soufamille
        public bool VerifierSousFamillesParFamille(int Id)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from SousFamilles where SousFamilles.RefFamille= @Id";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Id", Id);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            return Reader.HasRows;
        }


        public List<SousFamilles> GetAll()
        {
            List<SousFamilles> Resultats = new List<SousFamilles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from SousFamilles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    SousFamilles SousFamille = new SousFamilles();
                    SousFamille.Ref_Sous_Famille_Operation = (int)Reader["RefSousFamille"];
                    SousFamille.Ref_Famille_Operation = (int)Reader["RefFamille"];
                    SousFamille.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(SousFamille);
                }

            }
            return Resultats;
        }

        public List<SousFamilles> GetSousFamilles(int Id)
        {
            List<SousFamilles> Resultats = new List<SousFamilles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "SELECT * FROM SousFamilles WHERE SousFamilles.RefSousFamille= @Id";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteParameter Parametre = new SQLiteParameter("@Id", System.Data.DbType.Int16);
            Parametre.Value = Id;
            Commande.Parameters.Add(Parametre);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    SousFamilles SousFamille = new SousFamilles();
                    SousFamille.Ref_Sous_Famille_Operation = (int)Reader["RefSousFamille"];
                    SousFamille.Ref_Famille_Operation = (int)Reader["RefFamille"];
                    SousFamille.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(SousFamille);
                }

            }
            return Resultats;
        }

        public List<SousFamilles> GetSousFamillesParNom(string Nom)
        {
            List<SousFamilles> Resultats = new List<SousFamilles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from SousFamilles where SousFamilles.Nom= @Nom";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Nom",Nom);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    SousFamilles SousFamille = new SousFamilles();
                    SousFamille.Ref_Sous_Famille_Operation = (int)Reader["RefSousFamille"];
                    SousFamille.Ref_Famille_Operation = (int)Reader["RefFamille"];
                    SousFamille.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(SousFamille);
                }

            }
            return Resultats;
        }

        public int Ajouter_Sous_Familles(int Id, int IdFaille, string Nom)
        {
            if (!VerifierSousFamilles(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "insert into SousFamilles values (@Id,@IdFamille,@Nom)";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                Commande.Parameters.AddWithValue("@Id", Id);
                Commande.Parameters.AddWithValue("@IdFamille", IdFaille);
                Commande.Parameters.AddWithValue("@Nom", Nom);
                return Commande.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }
        }

        public int SupprimerSousFamille(int Id)
        {
            if (VerifierSousFamilles(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "delete from SousFamilles where SousFamilles.RefSousFamille= @Id";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                Commande.Parameters.AddWithValue("Id",Id);
                return Commande.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }
        }

        public int MAJSousFamille(int IdNouv, int IdFamilleFNouv, string NomNouv, int Id)
        {
            if (VerifierSousFamilles(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "update SousFamilles set RefSousFamille= @IdNouv,RefFamille=@IdFamilleFNouv ,Nom=@NomNouv where SousFamilles.RefSousFamille=@Id";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                Commande.Parameters.AddWithValue("@IdNouv", IdNouv);
                Commande.Parameters.AddWithValue("@IdFamilleFNouv", IdFamilleFNouv);
                Commande.Parameters.AddWithValue("@NomNouv", NomNouv);
                Commande.Parameters.AddWithValue("@Id", Id);
                return Commande.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }
        }

        public int SupprimerTous()
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "delete from SousFamilles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            return Commande.ExecuteNonQuery();
        }
    }
}
