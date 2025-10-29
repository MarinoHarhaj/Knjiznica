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
    public partial class Ucenici : Form
    {

        PodatkovniKontekst Kontekst;

        public Ucenici(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.Kontekst = kontekst;
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            OsvjeziUcenike();
        }

        private void OsvjeziUcenike()
        {

            Helper.PrikaziListuUListBoxu<Ucenik>(this.Kontekst.Ucenici, lbUcenici);
            
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DetaljiUcenika detaljiUcenika = new DetaljiUcenika();

          

            if (detaljiUcenika.ShowDialog() == DialogResult.OK)
            {
                this.Kontekst.DodajUcenika(detaljiUcenika.Ucenik);
                OsvjeziUcenike();
                 
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            if(lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molim te odaberi ucenika");
            }

            else
            {
                DetaljiUcenika detaljiUcenika = new DetaljiUcenika();
                detaljiUcenika.Ucenik = (Ucenik)lbUcenici.SelectedItem;

                if(detaljiUcenika.ShowDialog() == DialogResult.OK)
                {
                    this.Kontekst.SpremiUcenike();
                    OsvjeziUcenike();
                }
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(lbUcenici.SelectedItem == null)
            {
                MessageBox.Show("Molim te odaberi ucenika");
            }
            else
            {
                this.Kontekst.BrisiUcenika((Ucenik)lbUcenici.SelectedItem);
                OsvjeziUcenike();
            }
        }
    }
}
