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
    public partial class Familles_Form : Form
    {


        List<Familles> ListFamille = new List<Familles>();

        FamillesDAO FamilleDAO = new FamillesDAO();

        private ListViewColumnSort Sorter = new ListViewColumnSort();


        public Familles_Form()
        {
            InitializeComponent();
            Update_ListView_Famille();
        }
        private void Update_ListView_Famille()
        {

            FamillesDAO FamilleDAO = new FamillesDAO();
            ListFamille = FamilleDAO.GetAll();
            this.ListView_Familles.BeginUpdate();
            this.ListView_Familles.Items.Clear();
            int i;
            for (i = 0; i < ListFamille.Count; i++)
            {
                this.ListView_Familles.Items.Add(ListFamille[i].Nom_Operation);
            }

            this.ListView_Familles.EndUpdate();
        }

        private void ListView_Familles_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            this.ListView_Familles.ListViewItemSorter = this.Sorter;
            if (e.Column == Sorter.SortColumn)
            {
                if (Sorter.Order == SortOrder.Ascending)
                {
                    Sorter.Order = SortOrder.Descending;
                }
                else
                {
                    Sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                Sorter.SortColumn = e.Column;
                Sorter.Order = SortOrder.Ascending;
            }
            this.ListView_Familles.Sort();
            this.ListView_Familles.Update();
        }

        private void ListView_Familles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                contextMenuStrip1.Show(this.ListView_Familles, p);
            }
        }

        private void ListView_Familles_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    this.ListView_Familles.ListViewItemSorter = null;
                    this.Update_ListView_Famille();
                    this.ListView_Familles.Update();
                    this.ListView_Familles.Refresh();
                    break;
                case Keys.Delete:
                    if (this.ListView_Familles.SelectedItems.Count > 0)
                    {
                        string nomFamille = this.ListView_Familles.SelectedItems[0].Text;
                        int refFamille = FamilleDAO.Rechercher_Famille_Par_Nom(nomFamille)[0].Ref_Famille_Operation;
                        if (MessageBox.Show("Supprimer cette Famille ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (FamilleDAO.Supprimer_Famille(nomFamille))
                            {
                                this.ListView_Familles.ListViewItemSorter = null;
                                this.Update_ListView_Famille();
                                this.ListView_Familles.Update();
                                this.ListView_Familles.Refresh();
                                this.toolStripStatusLabel1.Text = "Famille supprimée !";
                            }
                            else
                            {
                                this.ListView_Familles.ListViewItemSorter = null;
                                this.Update_ListView_Famille();
                                this.ListView_Familles.Update();
                                this.ListView_Familles.Refresh();
                                this.toolStripStatusLabel1.Text = "Famille est deja exsite dans la sousFamile !";
                            }
                        }
                    }
                    break;
                case Keys.Enter:
                    if (this.ListView_Familles.SelectedItems.Count > 0)
                    {
                        Familles Famille = new Familles();

                        int i;
                        for (i = 0; i < ListFamille.Count; i++)
                        {
                            if (ListFamille[i].Nom_Operation.Equals(this.ListView_Familles.SelectedItems[0].Text))
                            {
                                Famille.Nom_Operation = ListFamille[i].Nom_Operation;
                                Famille.Ref_Famille_Operation = ListFamille[i].Ref_Famille_Operation;
                                break;
                            }
                        }
                        Modifier_Familles_Form Form = new Modifier_Familles_Form(Famille);
                        Form.ShowDialog(this);

                        this.toolStripStatusLabel1.Text = "Famille modifiée !";
                        this.ListView_Familles.ListViewItemSorter = null;
                        this.Update_ListView_Famille();
                        this.ListView_Familles.Update();
                        this.ListView_Familles.Refresh();
                    }
                    break;
                default:
                    break;
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Familles_Form Form = new Ajouter_Familles_Form();
            Form.ShowDialog(this);
            this.ListView_Familles.ListViewItemSorter = null;
            this.Update_ListView_Famille();
            this.ListView_Familles.Update();
            this.ListView_Familles.Refresh();
            this.toolStripStatusLabel1.Text = "Famille ajoutée !";

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ListView_Familles.SelectedItems.Count > 0)
            {
                Familles Famille = new Familles();

                int i;
                for (i = 0; i < ListFamille.Count; i++)
                {
                    if (ListFamille[i].Nom_Operation.Equals(this.ListView_Familles.SelectedItems[0].Text))
                    {
                        Famille.Nom_Operation = ListFamille[i].Nom_Operation;
                        Famille.Ref_Famille_Operation = (ListFamille[i].Ref_Famille_Operation);
                        break;
                    }
                }

                Modifier_Familles_Form Form = new Modifier_Familles_Form(Famille);
                Form.ShowDialog(this);
                this.toolStripStatusLabel1.Text = "Famille modifiée !";
                this.ListView_Familles.ListViewItemSorter = null;
                this.Update_ListView_Famille();
                this.ListView_Familles.Update();
                this.ListView_Familles.Refresh();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ListView_Familles.SelectedItems.Count > 0)
            {
                string nomFamille = this.ListView_Familles.SelectedItems[0].Text;
                if (MessageBox.Show("Supprimer cette Famille ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FamilleDAO.Supprimer_Famille(nomFamille);
                    this.ListView_Familles.ListViewItemSorter = null;
                    this.Update_ListView_Famille();
                    this.ListView_Familles.Update();
                    this.ListView_Familles.Refresh();
                    this.toolStripStatusLabel1.Text = "Famille supprimée !";
                }
            }
        }

        private void ListView_Familles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ListView_Familles.SelectedItems.Count > 0)
            {
                Familles famille = new Familles();

                int i;
                for (i = 0; i < ListFamille.Count; i++)
                {
                    if (ListFamille[i].Nom_Operation.Equals(this.ListView_Familles.SelectedItems[0].Text))
                    {
                        famille.Nom_Operation = (ListFamille[i].Nom_Operation);
                        famille.Ref_Famille_Operation = (ListFamille[i].Ref_Famille_Operation);
                        break;
                    }
                }

                Modifier_Familles_Form Form = new Modifier_Familles_Form(famille);
                Form.ShowDialog(this);

                this.toolStripStatusLabel1.Text = "Famille modifiée !";
                this.ListView_Familles.ListViewItemSorter = null;
                this.Update_ListView_Famille();
                this.ListView_Familles.Update();
                this.ListView_Familles.Refresh();
            }
        }
    }
}








