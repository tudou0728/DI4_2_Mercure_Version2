using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.dao;
using Mercure.Model;

namespace Mercure.Vue
{
    public partial class Modifier_Article_Form : Form
    {
        //par default est la modele-modifier
        public Modifier_Article_Form()
        {
            InitializeComponent();
            this.TextBox_RefArticle.Hide();
            this.Button_Ajouter.Hide();
            Form_Donnees_Initialiser();
        }

        public Modifier_Article_Form(string RefArticle,string Modele)
        {
            InitializeComponent();      
            //si ajouter un article, utiliser cette modele
            if (string.Compare(Modele, "Ajouter")==0)
            {
                this.Text = "Ajouter un Article";
                this.Button_Modifier.Hide();
                this.Label_Ref_A.Hide();
                Marque_Box_Initialiser();
                Sous_Familles_Box_Initialiser();
                Familles_Box_Initialiser();
            }
            //si modifier un article, utiliser cette modele
            if (string.Compare(Modele, "Modifier") == 0)
            {
                this.Text = "Modifier un Article";
                this.Button_Ajouter.Hide();
                this.TextBox_RefArticle.Hide();
                //this.TextBox_RefArticle.Text = RefArticle;
                this.Label_Ref_A.Text = RefArticle;
                Form_Donnees_Initialiser();
                Familles_Box_Initialiser();
            }
            
        }

        //les donnees initialiser 
        public void Form_Donnees_Initialiser()
        {
            Marque_Box_Initialiser();
            Sous_Familles_Box_Initialiser();
            ArticlesDAO Articles_DAO = new ArticlesDAO();
            Articles Article = Articles_DAO.Rechercher_Articles(this.Label_Ref_A.Text)[0];
            Console.Write(Article.Quantite_Operation);
            this.TextBox_Description.Text = Article.Description_Operation;
            this.TextBox_Prix.Text = Article.PrixTH_Operation.ToString();
            this.TextBox_Quantite.Text = Article.Quantite_Operation.ToString();
            this.ComboBox_Marque.Text = Article.Ref_Marque_Operation.ToString();
            this.ComboBox_SousFamille.Text = Article.Ref_Sous_Famille_Operation.ToString();
       }

        //combox initialiser
        public void Marque_Box_Initialiser()
        {
            this.ComboBox_Marque.Items.Clear();
            MarquesDAO Marque_DAO = new MarquesDAO();
            List<Marques> MarquesListe = Marque_DAO.GetAll();
            int CountM = 0;
            for (CountM = 0; CountM < MarquesListe.Count; CountM++)
            {
                this.ComboBox_Marque.Items.Add(MarquesListe[CountM].Ref_Marque_Operation);
            }              
        }

        //combox initialiser
        public void Sous_Familles_Box_Initialiser()
        {
            this.ComboBox_SousFamille.Items.Clear();
            SousFamillesDAO Sous_Famille_DAO = new SousFamillesDAO();
            List<SousFamilles> SousFamillesListe = Sous_Famille_DAO.GetAll();
            int CountS = 0;
            for (CountS = 0; CountS < SousFamillesListe.Count; CountS++)
            {
                this.ComboBox_SousFamille.Items.Add(SousFamillesListe[CountS].Ref_Sous_Famille_Operation);
            }     
        }

        public void Familles_Box_Initialiser()
        {
            this.ComboBox_Famille.Items.Clear();
            if (string.Compare(this.ComboBox_SousFamille.Text, "") == 0 )
            {
                FamillesDAO Famille_DAO = new FamillesDAO();
                List<Familles> FamillesListe = Famille_DAO.GetAll();
                int CountF = 0;
                for (CountF = 0; CountF < FamillesListe.Count; CountF++)
                {
                    this.ComboBox_Famille.Items.Add(FamillesListe[CountF].Ref_Famille_Operation);
                }
            }
            else
            {
                string Ref_S = this.ComboBox_SousFamille.Text;
                int Ref_SI = int.Parse(Ref_S);
                SousFamillesDAO Sous_Familles_DAO=new SousFamillesDAO();
                List<SousFamilles> SousfamillesListe = Sous_Familles_DAO.GetSousFamilles(Ref_SI);
                if (SousfamillesListe != null && SousfamillesListe.Count > 0)
                {
                    this.ComboBox_Famille.Items.Add(SousfamillesListe[0].Ref_Famille_Operation.ToString());
                    this.ComboBox_Famille.Text = SousfamillesListe[0].Ref_Famille_Operation.ToString();
                }
                else
                {
                    MessageBox.Show("Pas de cette SousFamille");
                }
            }
        }

        // controler les entree:juste Int
        private void TextBox_Quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) // 只能输入数字或backspace
            {
                e.Handled = true;//表示该操作已经处理过了，不再处理（系统不再处理该操作）
            }
        }

        //controler les entree:juste float
        private void TextBox_Prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能是数字或者小数点
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
            else
            {
                if ((int)e.KeyChar == 46)//如果是小数点 不能放在第一位
                {
                    if (this.TextBox_Prix.TextLength <= 0)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        //controler les entree:juste format comme: F1234567
        private void TextBox_RefArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48 && (int)e.KeyChar != 8) || ((int)e.KeyChar > 57) && (int)e.KeyChar != 70))
            {
                e.Handled = true;
            }
            else
            {
                if ((int)e.KeyChar == 70)//格式必须是：F+7位数字吗？
                {
                    if (this.TextBox_RefArticle.TextLength > 0)
                    {
                        e.Handled = true;
                    }
                }
                else if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                {
                    if (this.TextBox_RefArticle .TextLength> 7)
                    {
                        e.Handled = true;
                    }
                }
                
            }
        }

        //annuler button
        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ajouter button
        private void Button_Ajouter_Click(object sender, EventArgs e)
        {
            string Ref_A = this.TextBox_RefArticle.Text;
            string Description = this.TextBox_Description.Text;
            string SousFamilles = this.ComboBox_SousFamille.Text;
            string Marque = this.ComboBox_Marque.Text;
            string Prix = this.TextBox_Prix.Text;
            string Quantite = this.TextBox_Quantite.Text;
            int QuantiteI;
            float PrixF;
            if (int.TryParse(Quantite, out QuantiteI))
            {
                if (float.TryParse(Prix, out PrixF))
                {
                    if (MessageBox.Show("Vous voulez ajouter L'Article: " + Ref_A,
                        "Operation: Modifier un Article", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ArticlesDAO Article_DAO = new ArticlesDAO();
                        Article_DAO.Ajouter_Artcle(Ref_A, Description, int.Parse(SousFamilles), int.Parse(Marque), QuantiteI, PrixF);
                        MessageBox.Show("Cet Article est ajouter,vous pouvez utiliser F5 à la fenêtre principale pour recharger.", "Operation: Ajouter");
                        this.TextBox_RefArticle.Clear();
                        this.TextBox_Description.Clear();
                        this.TextBox_Prix.Clear();
                        this.TextBox_Quantite.Clear();
                        Marque_Box_Initialiser();
                        Sous_Familles_Box_Initialiser();
                        Familles_Box_Initialiser();                       
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Quantite: il faut Float", "Attention: Ajouter");
                }
            }
            else
            {
                MessageBox.Show("Quantite: il faut INT", "Attention: Ajouter");
            }                
        }

        //modifier button
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string Ref_Article = this.Label_Ref_A.Text;
            ArticlesDAO Article_DAO=new ArticlesDAO();
            List<Articles> ArticlesListe = Article_DAO.Rechercher_Articles(Ref_Article);
            if (ArticlesListe != null && ArticlesListe.Count > 0)
            {
                Articles Article = ArticlesListe[0];
                string Description = this.TextBox_Description.Text;
                string SousFamilles = this.ComboBox_SousFamille.Text;
                string Marque = this.ComboBox_Marque.Text;
                string Prix = this.TextBox_Prix.Text;
                string Quantite = this.TextBox_Quantite.Text;
                int QuantiteI;
                float PrixF;
                if (int.TryParse(Quantite, out QuantiteI))
                {
                    if (float.TryParse(Prix, out PrixF))
                    {
                        if (MessageBox.Show("Vous voulez modifier L'Article: " + Article.Ref_Article_Operation, 
                            "Operation: Modifier un Article", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Article_DAO.Modifier_Article(Article.Ref_Article_Operation, Description, int.Parse(SousFamilles), int.Parse(Marque), QuantiteI, PrixF);
                            MessageBox.Show("Cet Article est modifier,vous pouvez utiliser F5 à la fenêtre principale pour recharger.", "Operation: Modifier");
                            this.Close();
                        }
                        else
                        {
                            this.Label_Ref_A.Text = Article.Ref_Article_Operation;
                            Form_Donnees_Initialiser();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantite: il faut Float", "Attention: Modifier");
                    }
                }
                else
                {
                    MessageBox.Show("Quantite: il faut INT", "Attention: Modifier");
                }                
            }
            else
            {
                MessageBox.Show("Il n'y a pas de cet Article.","Attention: Modifier");
            }           
        }

        private void ComboBox_SousFamille_TextChanged(object sender, EventArgs e)
        {
            this.ComboBox_Famille.Items.Clear();
            string Ref_S = this.ComboBox_SousFamille.Text;
            int Ref_SI = int.Parse(Ref_S);
            SousFamillesDAO Sous_Familles_DAO = new SousFamillesDAO();
            List<SousFamilles> SousfamillesListe = Sous_Familles_DAO.GetSousFamilles(Ref_SI);
            if (SousfamillesListe != null && SousfamillesListe.Count > 0)
            {
                this.ComboBox_Famille.Items.Add(SousfamillesListe[0].Ref_Famille_Operation.ToString());
                this.ComboBox_Famille.Text = SousfamillesListe[0].Ref_Famille_Operation.ToString();
            }
            else
            {
                MessageBox.Show("Pas de cette SousFamille");
            }
        }

        public bool Verifier_Box()
        {
            if (string.Compare(this.TextBox_Description.Text, "") == 0
                || string.Compare(this.TextBox_Prix.Text, "") == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //未完成 需要控制必须所有的信息都填满才可以增加或删除
    }
}
