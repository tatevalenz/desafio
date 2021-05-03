using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio
{
    public partial class CapituloFinal : Form
    {
        public CapituloFinal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Capitulo0 cap0 = new Capitulo0();
            
            cap0.ShowDialog();
            Close();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Final fin = new Final();
            
            fin.ShowDialog();
            this.Close();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Fin fin = new Fin();
            
            fin.ShowDialog();
            this.Close();
        }
    }
}
