using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private void ouch(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            btnTest.Click += ouch;
        }

        private void btnEnlever_Click(object sender, EventArgs e)
        {
            btnTest.Click -= ouch;
        }
    }
}
