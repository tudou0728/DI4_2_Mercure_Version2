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
    /// <summary>
    /// ClasseName:FamillesDAO
    /// Author: Alafate ABULIMITI Yuanyuan LI
    /// </summary>
    /// <remarks>
    /// Cette classe est pour gerer la classe famille
    /// </remarks>>
    class FamillesDAO
    {
        private SousFamillesDAO SousFamilleDAO  = new SousFamillesDAO();

        /// <summary>
        /// Ajouter une famille
        /// </summary>
        /// <param name="Ref_Famille"></param>
        /// <param name="Nom"></param>
        public void Ajouter_Famille(int Ref_Famille, string Nom)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "insert into Familles Values(@Ref_Famille, @Nom)";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.CommandText = Sql;
            Commande.Parameters.AddWithValue("@Ref_Famille", Ref_Famille);
            Commande.Parameters.AddWithValue("@Nom", Nom);
            Commande.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprimer une famille
        /// </summary>
        /// <param name="Nom"></param>
        public bool Supprimer_Famille(string Nom)
        {
            bool b = SousFamilleDAO.VerifierSousFamillesParFamille(Rechercher_Famille_Par_Nom(Nom)[0].Ref_Famille_Operation);
            if(!b){
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "delete from Familles where Nom = @Nom";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.CommandText = Sql;
            Cmd.Parameters.AddWithValue("@Nom", Nom);
            Cmd.ExecuteNonQuery();
            return true;
            }else{
            return false;
            }
        }

        /// <summary>
        /// Modifier une famille
        /// </summary>
        /// <param name="Ref_Famille"></param>
        /// <param name="Nom"></param>
        public bool Modifier_Famille(int Ref_Famille, string Nom)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "update Familles set Nom = @Nom where RefFamille = @Ref_Famille";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.CommandText = Sql;
            Cmd.Parameters.AddWithValue("@Ref_Famille", Ref_Famille);
            Cmd.Parameters.AddWithValue("@Nom", Nom);
            Cmd.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// Rechercher une famille par Ref_Famille
        /// </summary>
        /// <param name="Ref_Famille"></param>
        public List<Familles> Rechercher_Familles(int Ref_Famille)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Familles where RefFamille = @Ref_Famille";
            SQLiteCommand Cmd = new SQLiteCommand(Sql, ConnectionBD);
            Cmd.CommandText = Sql;
            Cmd.Parameters.AddWithValue("@Ref_Famille", Ref_Famille);
            Cmd.ExecuteNonQuery();
            List<Familles> List = new List<Familles>();
            SQLiteDataReader Reader = Cmd.ExecuteReader();
            while (Reader.Read())
            {
                int Ref_Famille1 = (int)Reader["RefFamille"];
                string Nom = Reader["Nom"].ToString();

                Familles Famille = new Familles();
                Famille.Ref_Famille_Operation = Ref_Famille1;
                Famille.Nom_Operation = Nom;
                List.Add(Famille);
            }
            return List;
        }

        /// <summary>
        /// Rechercher une famille par nom
        /// </summary>
        /// <param name="Nom"></param>
        public List<Familles> Rechercher_Famille_Par_Nom(string Nom)
        {
            List<Familles> Resultats = new List<Familles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Familles where Familles.Nom= @Nom";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Nom", Nom);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Familles Famille = new Familles();
                    Famille.Ref_Famille_Operation = (int)Reader["RefFamille"];
                    Famille.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(Famille);
                }
            }
            return Resultats;
        }

        /// <summary>
        /// Rechercher tous  les famille et  les stocker  dans une liste
        /// </summary>
        public List<Familles> GetAll()
        {
            List<Familles> Resultats = new List<Familles>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Familles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Familles Famille = new Familles();
                    Famille.Ref_Famille_Operation = (int)Reader["RefFamille"];
                    Famille.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(Famille);
                }
            }
            return Resultats;
        }

        /// <summary>
        /// Supprimer tous  les famille 
        /// </summary>
        public int SupprimerTous()
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "delete from Familles";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            return Commande.ExecuteNonQuery();
        }
    }
}
