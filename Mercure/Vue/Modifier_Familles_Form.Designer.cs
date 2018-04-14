namespace Mercure.Vue
{
    partial class Modifier_Familles_Form
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
            this.Label_Modifier_Famille = new System.Windows.Forms.Label();
            this.textBox_Modifier_Famille = new System.Windows.Forms.TextBox();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Modifier_Famille
            // 
            this.Label_Modifier_Famille.AutoSize = true;
            this.Label_Modifier_Famille.Location = new System.Drawing.Point(12, 94);
            this.Label_Modifier_Famille.Name = "Label_Modifier_Famille";
            this.Label_Modifier_Famille.Size = new System.Drawing.Size(35, 12);
            this.Label_Modifier_Famille.TabIndex = 6;
            this.Label_Modifier_Famille.Text = "Nom :";
            // 
            // textBox_Modifier_Famille
            // 
            this.textBox_Modifier_Famille.Location = new System.Drawing.Point(71, 91);
            this.textBox_Modifier_Famille.Name = "textBox_Modifier_Famille";
            this.textBox_Modifier_Famille.Size = new System.Drawing.Size(170, 21);
            this.textBox_Modifier_Famille.TabIndex = 7;
            // 
            // button_Modifier
            // 
            this.button_Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Modifier.Location = new System.Drawing.Point(33, 178);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 8;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = false;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(166, 178);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.button_Annuler.TabIndex = 9;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // Modifier_Familles_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.textBox_Modifier_Famille);
            this.Controls.Add(this.Label_Modifier_Famille);
            this.Name = "Modifier_Familles_Form";
            this.Text = "Modifer_Familles_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Modifier_Famille;
        private System.Windows.Forms.TextBox textBox_Modifier_Famille;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Annuler;
    }
}