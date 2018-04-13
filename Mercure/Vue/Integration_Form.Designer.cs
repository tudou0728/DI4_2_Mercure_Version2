namespace Mercure
{
    partial class Integration_Form
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
            this.Button_Integration = new System.Windows.Forms.Button();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Radio_Button_Nouvelle = new System.Windows.Forms.RadioButton();
            this.Radio_Button_MAJ = new System.Windows.Forms.RadioButton();
            this.Label_Fichier = new System.Windows.Forms.Label();
            this.Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.Button_Fichier = new System.Windows.Forms.Button();
            this.Label_Chemin = new System.Windows.Forms.Label();
            this.Label_Chemin_Fichier = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Integration
            // 
            this.Button_Integration.Location = new System.Drawing.Point(533, 336);
            this.Button_Integration.Name = "Button_Integration";
            this.Button_Integration.Size = new System.Drawing.Size(139, 33);
            this.Button_Integration.TabIndex = 0;
            this.Button_Integration.Text = "Integration";
            this.Button_Integration.UseVisualStyleBackColor = true;
            this.Button_Integration.Click += new System.EventHandler(this.Button_Integration_Click);
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Type.Location = new System.Drawing.Point(43, 34);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(179, 17);
            this.Label_Type.TabIndex = 1;
            this.Label_Type.Text = "1. Choisir le type:";
            // 
            // Radio_Button_Nouvelle
            // 
            this.Radio_Button_Nouvelle.AutoSize = true;
            this.Radio_Button_Nouvelle.Location = new System.Drawing.Point(64, 82);
            this.Radio_Button_Nouvelle.Name = "Radio_Button_Nouvelle";
            this.Radio_Button_Nouvelle.Size = new System.Drawing.Size(196, 19);
            this.Radio_Button_Nouvelle.TabIndex = 2;
            this.Radio_Button_Nouvelle.TabStop = true;
            this.Radio_Button_Nouvelle.Text = "Nouvelle integration.";
            this.Radio_Button_Nouvelle.UseVisualStyleBackColor = true;
            // 
            // Radio_Button_MAJ
            // 
            this.Radio_Button_MAJ.AutoSize = true;
            this.Radio_Button_MAJ.Location = new System.Drawing.Point(64, 136);
            this.Radio_Button_MAJ.Name = "Radio_Button_MAJ";
            this.Radio_Button_MAJ.Size = new System.Drawing.Size(124, 19);
            this.Radio_Button_MAJ.TabIndex = 3;
            this.Radio_Button_MAJ.TabStop = true;
            this.Radio_Button_MAJ.Text = "Mise a jour.";
            this.Radio_Button_MAJ.UseVisualStyleBackColor = true;
            // 
            // Label_Fichier
            // 
            this.Label_Fichier.AutoSize = true;
            this.Label_Fichier.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Fichier.Location = new System.Drawing.Point(43, 201);
            this.Label_Fichier.Name = "Label_Fichier";
            this.Label_Fichier.Size = new System.Drawing.Size(224, 17);
            this.Label_Fichier.TabIndex = 4;
            this.Label_Fichier.Text = "2. Chosir le fichierXML.";
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.Location = new System.Drawing.Point(46, 336);
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(464, 33);
            this.Progress_Bar.TabIndex = 5;
            // 
            // Button_Fichier
            // 
            this.Button_Fichier.Location = new System.Drawing.Point(328, 193);
            this.Button_Fichier.Name = "Button_Fichier";
            this.Button_Fichier.Size = new System.Drawing.Size(155, 35);
            this.Button_Fichier.TabIndex = 6;
            this.Button_Fichier.Text = "Choisir fichier";
            this.Button_Fichier.UseVisualStyleBackColor = true;
            this.Button_Fichier.Click += new System.EventHandler(this.Button_Fichier_Click);
            // 
            // Label_Chemin
            // 
            this.Label_Chemin.AutoSize = true;
            this.Label_Chemin.Location = new System.Drawing.Point(71, 265);
            this.Label_Chemin.Name = "Label_Chemin";
            this.Label_Chemin.Size = new System.Drawing.Size(175, 15);
            this.Label_Chemin.TabIndex = 7;
            this.Label_Chemin.Text = "Le chemin de fichier:";
            // 
            // Label_Chemin_Fichier
            // 
            this.Label_Chemin_Fichier.AutoSize = true;
            this.Label_Chemin_Fichier.Location = new System.Drawing.Point(285, 265);
            this.Label_Chemin_Fichier.Name = "Label_Chemin_Fichier";
            this.Label_Chemin_Fichier.Size = new System.Drawing.Size(0, 15);
            this.Label_Chemin_Fichier.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(719, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(167, 20);
            this.ToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // Integration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Label_Chemin_Fichier);
            this.Controls.Add(this.Label_Chemin);
            this.Controls.Add(this.Button_Fichier);
            this.Controls.Add(this.Progress_Bar);
            this.Controls.Add(this.Label_Fichier);
            this.Controls.Add(this.Radio_Button_MAJ);
            this.Controls.Add(this.Radio_Button_Nouvelle);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Button_Integration);
            this.Name = "Integration_Form";
            this.Text = "Integration";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Integration;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.RadioButton Radio_Button_Nouvelle;
        private System.Windows.Forms.RadioButton Radio_Button_MAJ;
        private System.Windows.Forms.Label Label_Fichier;
        private System.Windows.Forms.ProgressBar Progress_Bar;
        private System.Windows.Forms.Button Button_Fichier;
        private System.Windows.Forms.Label Label_Chemin;
        private System.Windows.Forms.Label Label_Chemin_Fichier;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
    }
}