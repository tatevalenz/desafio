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
    public partial class Katana : Form
    {
        public Katana()
        {
            InitializeComponent();
        }

       

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            Capitulo0 cap0 = new Capitulo0();
           
            

            cap0.ShowDialog();
            this.Close();
        }
    }
}
