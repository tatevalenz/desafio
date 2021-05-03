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
    public partial class ComidaAz : Form
    {
        public ComidaAz()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Capitulo1Az cap1 = new Capitulo1Az();
            this.Close();
            cap1.ShowDialog();
        }
    }
}
