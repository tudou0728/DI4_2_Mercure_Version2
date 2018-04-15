namespace Mercure.Vue
{
    partial class Ajouter_Familles_Form
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
            this.Label_Ajouter_Famille = new System.Windows.Forms.Label();
            this.textBox_Ajouter_Famille = new System.Windows.Forms.TextBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Ajouter_Famille
            // 
            this.Label_Ajouter_Famille.AutoSize = true;
            this.Label_Ajouter_Famille.Location = new System.Drawing.Point(29, 102);
            this.Label_Ajouter_Famille.Name = "Label_Ajouter_Famille";
            this.Label_Ajouter_Famille.Size = new System.Drawing.Size(35, 12);
            this.Label_Ajouter_Famille.TabIndex = 10;
            this.Label_Ajouter_Famille.Text = "Nom :";
            // 
            // textBox_Ajouter_Famille
            // 
            this.textBox_Ajouter_Famille.Location = new System.Drawing.Point(70, 99);
            this.textBox_Ajouter_Famille.Name = "textBox_Ajouter_Famille";
            this.textBox_Ajouter_Famille.Size = new System.Drawing.Size(170, 21);
            this.textBox_Ajouter_Famille.TabIndex = 11;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Ajouter.Location = new System.Drawing.Point(31, 194);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 12;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = false;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(165, 194);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.button_Annuler.TabIndex = 13;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // Ajouter_Familles_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 286);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.textBox_Ajouter_Famille);
            this.Controls.Add(this.Label_Ajouter_Famille);
            this.Name = "Ajouter_Familles_Form";
            this.Text = "Ajouter_Familles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Ajouter_Famille;
        private System.Windows.Forms.TextBox textBox_Ajouter_Famille;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Annuler;
    }
}