using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.Vue;
using Mercure.Model;
using Mercure.dao;
using Mercure.controleur;
using System.Collections;
using System.Data.SQLite;
namespace Mercure.Vue
{
    public partial class Ajouter_Familles_Form : Form
    {
        List<Familles> ListFamille = new List<Familles>();
        FamillesDAO FamilleDAO = new FamillesDAO();

        public Ajouter_Familles_Form()
        {
            ListFamille.Clear();
            ListFamille = FamilleDAO.GetAll();
            InitializeComponent();
        }


        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {

            if (this.textBox_Ajouter_Famille.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nom unvalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            string nomFamille = this.textBox_Ajouter_Famille.Text.Trim();
            int RefFamille = 0;
            int MaxRefFamille = 0;
            int i;
            for (i = 0; i < ListFamille.Count; i++)
            {
                if (ListFamille[i].Ref_Famille_Operation > MaxRefFamille)
                {
                    MaxRefFamille = ListFamille[i].Ref_Famille_Operation;
                }
            }
            RefFamille = (++MaxRefFamille);
            List<Familles> List = FamilleDAO.Rechercher_Famille_Par_Nom(nomFamille);
            if (List  == null || List.Count() ==0)
            {
                FamilleDAO.Ajouter_Famille(RefFamille, nomFamille);
                this.Close();
            }
            else
            {
                MessageBox.Show("Famille existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
