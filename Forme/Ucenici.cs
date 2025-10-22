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

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
