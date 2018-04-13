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

namespace Mercure
{
    public partial class Main_Form : Form
    {
        private ListViewColumnSort Sorter = new ListViewColumnSort();

        public Main_Form()
        {
            InitializeComponent();
            this.CenterToScreen();
            Tool_Strip_Status_Label_BD.Text = "Connecter a la BD.";
            Tool_Strip_Status_Label_Selection.Text = "";
            Initialise_Articles_ListView();
            this.ListView_Articles.ListViewItemSorter = Sorter;
        }

        //integration form
        private void integrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integration_Form IntegrationForm=new Integration_Form();
            IntegrationForm.StartPosition = FormStartPosition.CenterParent;
            IntegrationForm.ShowDialog();
            Tool_Strip_Status_Label_Selection.Text = "   La derniere action: Integration.";
        }

        //initialiser listview
        private void Initialise_Articles_ListView()
        {
            this.ListView_Articles.Items.Clear();
            ArticlesDAO Articles_DAO = new ArticlesDAO();
            List<Articles> Articles = Articles_DAO.GetAll();
            this.Label_Article_Nombre.Text = "Il y a "+Articles.Count+" Articles";
            if (Articles != null && Articles.Count!=0)
            {
                int TempCount = 0;
                for (TempCount = 0; TempCount < Articles.Count; TempCount++)
                {
                    ListViewItem Item = new ListViewItem(Articles[TempCount].Ref_Article_Operation.ToString());
                    Item.SubItems.Add(Articles[TempCount].Description_Operation);
                    Item.SubItems.Add(Articles[TempCount].Ref_Sous_Famille_Operation.ToString());
                    Item.SubItems.Add(Articles[TempCount].Ref_Marque_Operation.ToString());
                    Item.SubItems.Add(Articles[TempCount].PrixTH_Operation.ToString());
                    Item.SubItems.Add(Articles[TempCount].Quantite_Operation.ToString());
                    this.ListView_Articles.Items.Add(Item);
                }
            }          
        }

        //F5 || Supp
        private void ListView_Articles_KeyDown(object sender, KeyEventArgs e)
        {
            Keys Key = e.KeyCode;
            if (Key == Keys.F5)
            {
                Initialise_Articles_ListView();
            }
            else if(Key==Keys.Delete)
            {
                if (this.ListView_Articles.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
                }
                else
                {
                    string RefArticle = this.ListView_Articles.SelectedItems[0].SubItems[0].Text.ToString();
                    if (MessageBox.Show("Vous voulez supprimer cet Article: " + RefArticle,
                        "Operation: Supprimer un Article", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ArticlesDAO Articles_DAO = new ArticlesDAO();
                        Articles_DAO.Supprimer_Article(RefArticle);
                        MessageBox.Show("Supprimer "+RefArticle+" , vous pouvez utliser F5 pour recharger.", "Operation: Supprimer un Article");
                    }
                }               
            }
            //Console.Write(Key);
        }

        //Sorter
        private void ListView_Articles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // 检查点击的列是不是现在的排序列.
            if (e.Column == Sorter.SortColumn)
            {
                // 重新设置此列的排序方法.
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
                // 设置排序列，默认为正向排序
                Sorter.SortColumn = e.Column;
                Sorter.Order = SortOrder.Ascending;
            }
            // 用新的排序方法对ListView排序
            this.ListView_Articles.Sort();
        }

        //double clique pour modifier un article
        private void ListView_Articles_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListView_Articles.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
            }
            else
            {
                Modifier_Article_Form Modifier_Article_Form = new Modifier_Article_Form(this.ListView_Articles.SelectedItems[0].SubItems[0].Text.ToString(),"Modifier");
                Modifier_Article_Form.StartPosition = FormStartPosition.CenterParent;
                Modifier_Article_Form.ShowDialog();
                Tool_Strip_Status_Label_Selection.Text = "   La derniere action: Modifier un Article.";
            }
        }

        
        //menue: Marque
        private void marquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marques_Form MarquesForm = new Marques_Form();
            MarquesForm.ShowDialog();
        }

        //menue:familles
        private void famillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Familles_Form FamillesForm = new Familles_Form();
            FamillesForm.ShowDialog();
        }

        //menue: sous famille
        private void sousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sous_Familles_Form SousFamillesForm = new Sous_Familles_Form();
            SousFamillesForm.ShowDialog();
        }

        //clique droit:modifier || ajouter || supprimer
        private void ListView_Articles_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.ListView_Articles.SelectedItems.Count > 0)
                {
                    this.ContextMenuStrip_Articles.Show(this, e.Location);
                }
                else
                {
                    this.ContextMenuStrip_Articles.Hide();
                    MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
                }
            }
        }

        //clique droit-modifier
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ListView_Articles.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
            }
            else
            {
                Modifier_Article_Form ModifierArticleForm = new Modifier_Article_Form(this.ListView_Articles.SelectedItems[0].SubItems[0].Text.ToString(), "Modifier");
                ModifierArticleForm.StartPosition = FormStartPosition.CenterParent;
                ModifierArticleForm.ShowDialog();
            }
        }

        //clique droit-supprimer
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ListView_Articles.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
            }
            else
            {
                string RefArticle = this.ListView_Articles.SelectedItems[0].SubItems[0].Text.ToString();
                if (MessageBox.Show("Vous voulez supprimer cet Article: " + RefArticle,
                    "Operation: Supprimer un Article", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ArticlesDAO Articles_DAO = new ArticlesDAO();
                    Articles_DAO.Supprimer_Article(RefArticle);
                    MessageBox.Show("Supprimer " + RefArticle + " , vous pouvez utliser F5 pour recharger.", "Operation: Supprimer un Article");
                }     
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ListView_Articles.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Il faut choisir un Article pour supprimer.Cliquez sur RefArticle, SVP.", "Warning");
            }
            else
            {
                Modifier_Article_Form ModifierArticleForm = new Modifier_Article_Form(this.ListView_Articles.SelectedItems[0].SubItems[0].Text.ToString(), "Ajouter");
                ModifierArticleForm.StartPosition = FormStartPosition.CenterParent;
                ModifierArticleForm.ShowDialog();
            }
        }
  
    }

}
