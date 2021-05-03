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
    public partial class Capitulo1Az : Form
    {
        public Capitulo1Az()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Capitulo0 cap0 = new Capitulo0();
           
            cap0.ShowDialog();
            this.Close();
        }

        private void btnBosque_Click(object sender, EventArgs e)
        {
            BosqueAz bosque = new BosqueAz();
            bosque.ShowDialog();
            this.Close();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            RutaAz ruta = new RutaAz();
            
            ruta.ShowDialog();
            this.Close();
        }
    }
}
