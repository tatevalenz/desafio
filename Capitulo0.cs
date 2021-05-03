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
    public partial class Capitulo0 : Form
    {
        public Capitulo0()
        {
            InitializeComponent();
        }

        

        private void btnAz_Click(object sender, EventArgs e)
        {
            ApocalipsisZombie apz = new ApocalipsisZombie();
            
            apz.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
