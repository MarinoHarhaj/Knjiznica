namespace Knjiznica.Forme
{
    partial class DetaljiPosudbe
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
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.dtpDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.cbBrojDana = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(30, 44);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(245, 108);
            this.lbUcenici.TabIndex = 0;
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.Location = new System.Drawing.Point(396, 44);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(245, 108);
            this.lbKnjige.TabIndex = 1;
            // 
            // dtpDatumPosudbe
            // 
            this.dtpDatumPosudbe.Location = new System.Drawing.Point(75, 196);
            this.dtpDatumPosudbe.Name = "dtpDatumPosudbe";
            this.dtpDatumPosudbe.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPosudbe.TabIndex = 2;
            // 
            // cbBrojDana
            // 
            this.cbBrojDana.FormattingEnabled = true;
            this.cbBrojDana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbBrojDana.Location = new System.Drawing.Point(396, 199);
            this.cbBrojDana.Name = "cbBrojDana";
            this.cbBrojDana.Size = new System.Drawing.Size(58, 21);
            this.cbBrojDana.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(279, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 44);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Učenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Knjiga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum Posudbe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj dana";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBrojDana);
            this.Controls.Add(this.dtpDatumPosudbe);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lbUcenici);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.DateTimePicker dtpDatumPosudbe;
        private System.Windows.Forms.ComboBox cbBrojDana;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}