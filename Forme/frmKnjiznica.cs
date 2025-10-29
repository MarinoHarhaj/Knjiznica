using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class frmKnjiznica : Form
    {
        PodatkovniKontekst kontekst;

        public frmKnjiznica()
        {
            InitializeComponent();
        }

        private void frmKnjiznica_Load(object sender, EventArgs e)
        {
            kontekst = new PodatkovniKontekst();
        }

        private void uceniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ucenici formaUcenici = new Ucenici(this.kontekst);
            formaUcenici.ShowDialog();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knjige formaKnjige = new Knjige(this.kontekst);
            formaKnjige.ShowDialog();
        }
    }
}
