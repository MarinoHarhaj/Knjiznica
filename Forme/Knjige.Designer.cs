namespace Knjiznica.Forme
{
    partial class Knjige
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
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.Location = new System.Drawing.Point(26, 78);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(379, 290);
            this.lbKnjige.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Knjige";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(506, 78);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 52);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(506, 194);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(105, 52);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(506, 316);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 52);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKnjige);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
    }
}