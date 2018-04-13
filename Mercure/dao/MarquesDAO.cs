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
    class MarquesDAO
    {
        public bool VerifierMarque(int Id)
        {
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Marques where Marques.RefMarque= @Id";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Id",Id);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            return Reader.HasRows;
        }

        public List<Marques> GetAll()
        {
            List<Marques> Resultats = new List<Marques>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Marques";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Marques Marque = new Marques();
                    Marque.Ref_Marque_Operation = (int)Reader["RefMarque"];
                    Marque.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(Marque);
                }

            }
            return Resultats;
        }

        public List<Marques> GetMarques(int Id)
        {
            List < Marques > Resultats= new List<Marques>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Marques where Marques.RefMarque= @Id";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            SQLiteParameter Parametre = new SQLiteParameter("@Id", System.Data.DbType.Int16);
            Parametre.Value = Id;
            Commande.Parameters.Add(Parametre);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Marques Marque = new Marques();
                    Marque.Ref_Marque_Operation = (int)Reader["RefMarque"];
                    Marque.Nom_Operation=Reader["Nom"].ToString();
                    Resultats.Add(Marque);
                }
                
            }
            return Resultats;
        }

        public List<Marques> GetMarquesParNom(string Nom)
        {
            List<Marques> Resultats = new List<Marques>();
            SQLiteConnection ConnectionBD = GererBD.Get_Connection();
            string Sql = "select * from Marques where Marques.Nom= @Nom";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            Commande.Parameters.AddWithValue("@Nom",Nom);
            SQLiteDataReader Reader = Commande.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Marques Marque = new Marques();
                    Marque.Ref_Marque_Operation = (int)Reader["RefMarque"];
                    Marque.Nom_Operation = Reader["Nom"].ToString();
                    Resultats.Add(Marque);
                }

            }
            return Resultats;
        }


        public int Ajouter_Marque(int Id, string Nom)
        {
            if (!VerifierMarque(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "insert into Marques values(@Id,@Nom)";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                SQLiteParameter Parametre1 = new SQLiteParameter("@Id", System.Data.DbType.Int16);
                SQLiteParameter Parametre2 = new SQLiteParameter("@Nom", System.Data.DbType.String);
                Parametre1.Value = Id;
                Parametre2.Value = Nom;
                Commande.Parameters.Add(Parametre1);
                Commande.Parameters.Add(Parametre2);
                return Commande.ExecuteNonQuery();
            }
            else
            {
                return 0;
            } 
        }

        public int SupprimerVersId(int Id)
        {
            if (VerifierMarque(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "delete from Marques where Marques.RefMarque= @Id";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                SQLiteParameter Parametre1 = new SQLiteParameter("@Id", System.Data.DbType.Int16);
                Parametre1.Value = Id;
                Commande.Parameters.Add(Parametre1);
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
            string Sql = "delete from Marques";
            SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
            return Commande.ExecuteNonQuery();
        }

        public int MAJMarques(int IdNouv, string NomNouv, int Id)
        {
            if (VerifierMarque(Id))
            {
                SQLiteConnection ConnectionBD = GererBD.Get_Connection();
                string Sql = "update Marques set RefMarque= @IdNouv,Nom= @NomNouv where Marques.RefMarque= @Id ";
                SQLiteCommand Commande = new SQLiteCommand(Sql, ConnectionBD);
                Commande.Parameters.AddWithValue("@IdNouv", IdNouv);
                Commande.Parameters.AddWithValue("@NomNouv", NomNouv);
                Commande.Parameters.AddWithValue("@Id", Id);
                return Commande.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }
        }
    }
}
