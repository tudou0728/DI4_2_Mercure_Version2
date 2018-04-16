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
    /// <summary>
    /// ClasseName:Modifier_Famille_Form
    /// Author: Alafate ABULIMITI Yuanyuan LI
    /// </summary>
    /// <remarks>
    /// Cette classe est pour modifier la famille.
    /// </remarks>>
    public partial class Modifier_Familles_Form : Form  
    {
        Familles Famille;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="famille"></param>
       public Modifier_Familles_Form(Familles Famille)
        {
            InitializeComponent();

            this.Famille = Famille;
            this.textBox_Modifier_Famille.Text = Famille.Nom_Operation;
        }

       /// <summary>
       /// Annuler l'opération
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Modifier une famille 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (this.textBox_Modifier_Famille.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nom unvalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            string nomFamille = this.textBox_Modifier_Famille.Text.Trim();
            FamillesDAO FamilleDAO = new FamillesDAO();
            List<Familles> List = FamilleDAO.Rechercher_Famille_Par_Nom(nomFamille);
            if (List  == null || List.Count() == 0)
            {
                FamilleDAO.Modifier_Famille(Famille.Ref_Famille_Operation, nomFamille);
                this.Close();
            }
            else {               
                MessageBox.Show("Famille existe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
