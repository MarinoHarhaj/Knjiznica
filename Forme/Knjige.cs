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
    public partial class Knjige : Form
    {

        public PodatkovniKontekst kontekst;




        public Knjige(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void Knjige_Load(object sender, EventArgs e)
        {

        }
    }
}
