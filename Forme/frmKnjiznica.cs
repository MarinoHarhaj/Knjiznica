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
            OsvjeziPosudbe();
        }

        private void OsvjeziPosudbe()
        {

            Helper.PrikaziListuUListBoxu<Posudba>(this.kontekst.Posudbe, lbPosudbe);
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

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            DetaljiPosudbe detaljiPosudbe = new DetaljiPosudbe(this.kontekst);


            if (detaljiPosudbe.ShowDialog() == DialogResult.OK)
            {

                this.kontekst.DodajPosudbu(detaljiPosudbe.Posudba);
                OsvjeziPosudbe();

            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbPosudbe.SelectedItem == null)
            {
                MessageBox.Show("Molim te odaberi Posudbu");
            }
            else
            {
                DetaljiPosudbe detaljiPosudbe = new DetaljiPosudbe(this.kontekst);
                detaljiPosudbe.Posudba = (Posudba)lbPosudbe.SelectedItem;

                if (detaljiPosudbe.ShowDialog() == DialogResult.OK)
                {
                    this.kontekst.SpremiPosudbe();
                    OsvjeziPosudbe();
                }
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {

            if (lbPosudbe.SelectedItem == null)
            {
                MessageBox.Show("Molim te odaberi posudbu");
            }
            else
            {

                this.kontekst.BrisiPosudbu((Posudba)lbPosudbe.SelectedItem);
                OsvjeziPosudbe();
            }


        }
    }
}
