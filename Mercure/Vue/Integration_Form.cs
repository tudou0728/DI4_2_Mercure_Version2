using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;
using Mercure.controleur;
using System.Threading;
using System.Diagnostics;

namespace Mercure
{
    public partial class Integration_Form : Form
    {
        private FichierControleur Fichier_Controleur = new FichierControleur();
        private AjouterControleur Ajouter_Controleur = new AjouterControleur();
        private SupprimerControleur Supprimer_Controleur = new SupprimerControleur();
        private OpenFileDialog Open_File_Dialog;
        private DialogResult Resultat;

        public Integration_Form()
        {
            InitializeComponent();
            ToolStripStatusLabel.Text = "Integration status";
        }

        private void Button_Fichier_Click(object sender, EventArgs e)
        {
            try 
            {
                Open_File_Dialog = new OpenFileDialog();
                Open_File_Dialog.InitialDirectory = Application.StartupPath;
                Open_File_Dialog.Filter = "XML Files|*.xml";

                //Thread InvokeThread = new Thread(new ThreadStart(Open_FileDialog));
                //InvokeThread.SetApartmentState(ApartmentState.STA);
                //InvokeThread.IsBackground = true;
                //InvokeThread.Start();
                //InvokeThread.Join();线程有点儿问题！！！！！有的时候会堵塞，目前还没找到解决办法。
                Resultat=Open_File_Dialog.ShowDialog() ;
                if (Resultat == DialogResult.OK)
                {
                    string Chemin = Open_File_Dialog.FileName.ToString();
                    Label_Chemin_Fichier.Text = Chemin;                 
                }
                else
                {
                    MessageBox.Show("Open dialog error.");
                }
            }
            catch (Exception Exception1)
            {
                MessageBox.Show(Exception1.Message);
            }
        }

        private void Button_Integration_Click(object sender, EventArgs e)
        {
            if (!this.Radio_Button_Nouvelle.Checked && !this.Radio_Button_MAJ.Checked)
            {
                MessageBox.Show("Il faut choisir le type d'integration.");
            }
            else if (Label_Chemin_Fichier.Text==null)
            {
                MessageBox.Show("Il faut choisir le fichier XML pour l'integration.");
            }
            else
            {
                List<List<string>> Articles = Fichier_Controleur.Lire_Fichier(Label_Chemin_Fichier.Text);                
                if (this.Radio_Button_Nouvelle.Checked)
                {
                    Supprimer_Controleur.SupprimerTous();
                }
                int CountA = Articles.Count;
                this.Progress_Bar.Maximum = CountA-1;
                ToolStripStatusLabel.Text = "Integration commence";
                int I = 0;
                for (I = 0; I < CountA; I++)
                {
                    List<string> Article = Articles[I];
                    string Description = Article[0];
                    string RefArticle = Article[1];
                    string Marque = Article[2];
                    string Famille = Article[3];
                    string SousFamille = Article[4];
                    string PrixHT = Article[5];
                    Ajouter_Controleur.AjouterArticle(Description, RefArticle, Marque, Famille, SousFamille, PrixHT, 0);//article的个数有点儿问题
                    this.Progress_Bar.Value = I;
                }
                MessageBox.Show("L'integration finit");
                Progress_Bar.Value = 0;
            }                 
        }
    }
}
