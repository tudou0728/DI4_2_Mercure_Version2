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
    public partial class Modifier_Familles_Form : Form  
    {
        Familles famille;

       public Modifier_Familles_Form(Familles famille)
        {
            InitializeComponent();

            this.famille = famille;
            this.textBox_Modifier_Famille.Text = famille.Nom_Operation;
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {

        }


    }
}
