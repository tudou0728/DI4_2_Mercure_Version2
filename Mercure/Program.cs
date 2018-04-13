using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Mercure.Model;
using Mercure.controleur;
using Mercure.dao;
using System.IO;

namespace Mercure
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //List<string> trest = new List<string>();
            //trest.Add("lalala");
            //Console.Write(trest.Count);

            //FichierControleur test = new FichierControleur();
            //List<List<string>> Resultat = test.Lire_Fichier("D:\\VS2012_workspace\\Mercure\\Mercure\\Mercure.xml");

            //链接库操作
            GererBD.Creer_Connection();
            GererBD.Open_Connection();

            //ArticlesDAO a = new ArticlesDAO();
            //a.Rechercher_Articles("F0000019");

            //数据库文件在debug文件夹下
            //FichierControleur f=new FichierControleur();
            //List<List<string>> Articles2 = f.Lire_Fichier("D:\\VS2012_workspace\\Mercure\\Mercure\\Mercure.xml");

            //AjouterControleur a = new AjouterControleur();
            //SupprimerControleur s = new SupprimerControleur();
            //s.SupprimerTous();
            //a.Integration(Articles2);

            //运行程序
            Application.Run(new Main_Form());

            //关闭数据库连接
            GererBD.Fermer_Connection();
        }
    }
}
