namespace Mercure.Vue
{
    partial class Familles_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListView_Familles = new System.Windows.Forms.ListView();
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Famille = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip_Famille.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView_Familles
            // 
            this.ListView_Familles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom});
            this.ListView_Familles.FullRowSelect = true;
            this.ListView_Familles.GridLines = true;
            this.ListView_Familles.Location = new System.Drawing.Point(41, 11);
            this.ListView_Familles.Margin = new System.Windows.Forms.Padding(2);
            this.ListView_Familles.Name = "ListView_Familles";
            this.ListView_Familles.Size = new System.Drawing.Size(239, 291);
            this.ListView_Familles.TabIndex = 0;
            this.ListView_Familles.UseCompatibleStateImageBehavior = false;
            this.ListView_Familles.View = System.Windows.Forms.View.Details;
            this.ListView_Familles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_Familles_ColumnClick);
            this.ListView_Familles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Familles_KeyDown);
            this.ListView_Familles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Familles_MouseClick);
            this.ListView_Familles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Familles_MouseDoubleClick);
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 236;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // statusStrip_Famille
            // 
            this.statusStrip_Famille.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_Famille.Location = new System.Drawing.Point(0, 304);
            this.statusStrip_Famille.Name = "statusStrip_Famille";
            this.statusStrip_Famille.Size = new System.Drawing.Size(342, 22);
            this.statusStrip_Famille.TabIndex = 1;
            this.statusStrip_Famille.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Familles_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 326);
            this.Controls.Add(this.statusStrip_Famille);
            this.Controls.Add(this.ListView_Familles);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Familles_Form";
            this.Text = "Familles_Form";
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip_Famille.ResumeLayout(false);
            this.statusStrip_Famille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Familles;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_Famille;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}