namespace Mercure
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main_Status_Strip = new System.Windows.Forms.StatusStrip();
            this.Tool_Strip_Status_Label_BD = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tool_Strip_Status_Label_Selection = new System.Windows.Forms.ToolStripStatusLabel();
            this.Main_Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView_Articles = new System.Windows.Forms.ListView();
            this.Header_Ref_Articles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Ref_SousFamilles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_RefMarque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_PrixHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label_Article_Nombre = new System.Windows.Forms.Label();
            this.ContextMenuStrip_Articles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Status_Strip.SuspendLayout();
            this.Main_Menu_Strip.SuspendLayout();
            this.ContextMenuStrip_Articles.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Status_Strip
            // 
            this.Main_Status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Strip_Status_Label_BD,
            this.Tool_Strip_Status_Label_Selection});
            this.Main_Status_Strip.Location = new System.Drawing.Point(0, 728);
            this.Main_Status_Strip.Name = "Main_Status_Strip";
            this.Main_Status_Strip.Size = new System.Drawing.Size(1482, 25);
            this.Main_Status_Strip.TabIndex = 0;
            this.Main_Status_Strip.Text = "statusStrip1";
            // 
            // Tool_Strip_Status_Label_BD
            // 
            this.Tool_Strip_Status_Label_BD.Name = "Tool_Strip_Status_Label_BD";
            this.Tool_Strip_Status_Label_BD.Size = new System.Drawing.Size(167, 20);
            this.Tool_Strip_Status_Label_BD.Text = "toolStripStatusLabel1";
            // 
            // Tool_Strip_Status_Label_Selection
            // 
            this.Tool_Strip_Status_Label_Selection.Name = "Tool_Strip_Status_Label_Selection";
            this.Tool_Strip_Status_Label_Selection.Size = new System.Drawing.Size(167, 20);
            this.Tool_Strip_Status_Label_Selection.Text = "toolStripStatusLabel2";
            // 
            // Main_Menu_Strip
            // 
            this.Main_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.Main_Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu_Strip.Name = "Main_Menu_Strip";
            this.Main_Menu_Strip.Size = new System.Drawing.Size(1482, 28);
            this.Main_Menu_Strip.TabIndex = 1;
            this.Main_Menu_Strip.Text = "menuStrip1";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrationToolStripMenuItem,
            this.donneesToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.xMLToolStripMenuItem.Text = "Menu";
            // 
            // integrationToolStripMenuItem
            // 
            this.integrationToolStripMenuItem.Name = "integrationToolStripMenuItem";
            this.integrationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.integrationToolStripMenuItem.Text = "Integration";
            this.integrationToolStripMenuItem.Click += new System.EventHandler(this.integrationToolStripMenuItem_Click);
            // 
            // donneesToolStripMenuItem
            // 
            this.donneesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marquesToolStripMenuItem,
            this.famillesToolStripMenuItem,
            this.sousToolStripMenuItem});
            this.donneesToolStripMenuItem.Name = "donneesToolStripMenuItem";
            this.donneesToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.donneesToolStripMenuItem.Text = "Donnees";
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.marquesToolStripMenuItem.Text = "Marques";
            this.marquesToolStripMenuItem.Click += new System.EventHandler(this.marquesToolStripMenuItem_Click);
            // 
            // famillesToolStripMenuItem
            // 
            this.famillesToolStripMenuItem.Name = "famillesToolStripMenuItem";
            this.famillesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.famillesToolStripMenuItem.Text = "Familles";
            this.famillesToolStripMenuItem.Click += new System.EventHandler(this.famillesToolStripMenuItem_Click);
            // 
            // sousToolStripMenuItem
            // 
            this.sousToolStripMenuItem.Name = "sousToolStripMenuItem";
            this.sousToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.sousToolStripMenuItem.Text = "Sous-familles";
            this.sousToolStripMenuItem.Click += new System.EventHandler(this.sousToolStripMenuItem_Click);
            // 
            // ListView_Articles
            // 
            this.ListView_Articles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header_Ref_Articles,
            this.Header_Description,
            this.Header_Ref_SousFamilles,
            this.Header_RefMarque,
            this.Header_PrixHT,
            this.Header_Quantite});
            this.ListView_Articles.Location = new System.Drawing.Point(0, 90);
            this.ListView_Articles.Name = "ListView_Articles";
            this.ListView_Articles.Size = new System.Drawing.Size(1200, 600);
            this.ListView_Articles.TabIndex = 2;
            this.ListView_Articles.UseCompatibleStateImageBehavior = false;
            this.ListView_Articles.View = System.Windows.Forms.View.Details;
            this.ListView_Articles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_Articles_ColumnClick);
            this.ListView_Articles.DoubleClick += new System.EventHandler(this.ListView_Articles_DoubleClick);
            this.ListView_Articles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Articles_KeyDown);
            this.ListView_Articles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView_Articles_MouseUp);
            // 
            // Header_Ref_Articles
            // 
            this.Header_Ref_Articles.Text = "RefArticle";
            this.Header_Ref_Articles.Width = 134;
            // 
            // Header_Description
            // 
            this.Header_Description.Text = "Description";
            this.Header_Description.Width = 243;
            // 
            // Header_Ref_SousFamilles
            // 
            this.Header_Ref_SousFamilles.Text = "RefSousFamille";
            this.Header_Ref_SousFamilles.Width = 130;
            // 
            // Header_RefMarque
            // 
            this.Header_RefMarque.Text = "RefMarque";
            this.Header_RefMarque.Width = 95;
            // 
            // Header_PrixHT
            // 
            this.Header_PrixHT.Text = "PrixHT";
            this.Header_PrixHT.Width = 92;
            // 
            // Header_Quantite
            // 
            this.Header_Quantite.Text = "Quantite";
            this.Header_Quantite.Width = 88;
            // 
            // Label_Article_Nombre
            // 
            this.Label_Article_Nombre.AutoSize = true;
            this.Label_Article_Nombre.Location = new System.Drawing.Point(12, 56);
            this.Label_Article_Nombre.Name = "Label_Article_Nombre";
            this.Label_Article_Nombre.Size = new System.Drawing.Size(0, 15);
            this.Label_Article_Nombre.TabIndex = 3;
            // 
            // ContextMenuStrip_Articles
            // 
            this.ContextMenuStrip_Articles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ContextMenuStrip_Articles.Name = "ContextMenuStrip_Articles";
            this.ContextMenuStrip_Articles.Size = new System.Drawing.Size(156, 98);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.Label_Article_Nombre);
            this.Controls.Add(this.ListView_Articles);
            this.Controls.Add(this.Main_Status_Strip);
            this.Controls.Add(this.Main_Menu_Strip);
            this.MainMenuStrip = this.Main_Menu_Strip;
            this.Name = "Main_Form";
            this.Text = "Main_Windows";
            this.Main_Status_Strip.ResumeLayout(false);
            this.Main_Status_Strip.PerformLayout();
            this.Main_Menu_Strip.ResumeLayout(false);
            this.Main_Menu_Strip.PerformLayout();
            this.ContextMenuStrip_Articles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Main_Status_Strip;
        private System.Windows.Forms.MenuStrip Main_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Tool_Strip_Status_Label_BD;
        private System.Windows.Forms.ToolStripStatusLabel Tool_Strip_Status_Label_Selection;
        private System.Windows.Forms.ListView ListView_Articles;
        private System.Windows.Forms.ToolStripMenuItem donneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sousToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Header_Ref_Articles;
        private System.Windows.Forms.ColumnHeader Header_Description;
        private System.Windows.Forms.ColumnHeader Header_Ref_SousFamilles;
        private System.Windows.Forms.ColumnHeader Header_RefMarque;
        private System.Windows.Forms.ColumnHeader Header_PrixHT;
        private System.Windows.Forms.ColumnHeader Header_Quantite;
        private System.Windows.Forms.Label Label_Article_Nombre;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Articles;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

