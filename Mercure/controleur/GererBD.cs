using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mercure.controleur
{
    class GererBD
    {
        private static SQLiteConnection BD_Connection;

        public static void Creer_Connection()
        {
            BD_Connection = new SQLiteConnection("Data Source=Mercure.SQLite;Version=3;");
        }

        public static SQLiteConnection Open_Connection()
        {
            BD_Connection.Open();
            Console.Write("Ouvrire la connection.\n");
            return BD_Connection;
        }

        public static SQLiteConnection Get_Connection()
        {
            return BD_Connection;
        }

        public static void Fermer_Connection()
        {
            if (BD_Connection != null)
            {
                BD_Connection.Close();
                Console.Write("Fermer la connection.\n");
            }
        }
    }
}
