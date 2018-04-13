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
            this.ListView_Familles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListView_Familles
            // 
            this.ListView_Familles.Location = new System.Drawing.Point(0, 84);
            this.ListView_Familles.Name = "ListView_Familles";
            this.ListView_Familles.Size = new System.Drawing.Size(806, 328);
            this.ListView_Familles.TabIndex = 0;
            this.ListView_Familles.UseCompatibleStateImageBehavior = false;
            // 
            // Familles_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 483);
            this.Controls.Add(this.ListView_Familles);
            this.Name = "Familles_Form";
            this.Text = "Familles_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Familles;
    }
}