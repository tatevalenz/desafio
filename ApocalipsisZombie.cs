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
    public partial class ApocalipsisZombie : Form
    {
        public ApocalipsisZombie()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKatana_Click(object sender, EventArgs e)
        {
            Katana kat = new Katana();
            this.Close();
            kat.ShowDialog();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            ComidaAz comAz = new ComidaAz();
            this.Close();
            comAz.ShowDialog();
        }

        private void btnVendaje_Click(object sender, EventArgs e)
        {
            VendajeAz venda = new VendajeAz();
            this.Close();
            venda.ShowDialog();
        }
    }
}
