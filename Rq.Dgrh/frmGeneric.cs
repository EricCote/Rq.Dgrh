using Rq.Dgrh.LaZone;
using System;
using System.Collections;
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
    public partial class frmGeneric : Form
    {
        public frmGeneric()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triple<int,int,bool> t = new Triple<int,int,bool>(5, 6, false);
            t.A = 5;
        }


        private string megaToString<T>(T a, T b)
        {
            return a.ToString() + " " + b.ToString();
        }

    }
}
