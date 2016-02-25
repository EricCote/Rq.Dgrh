using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 200000; i++)
            {
                result = "A";
            }
            chrono.Stop();

            MessageBox.Show(string.Format("Le temps écoulé" +
                "est de {0}", 
                chrono.ElapsedMilliseconds));

        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 200000; i++)
            {
                
                result.Append("A");
                result.Remove(0, result.Length);
            }
            chrono.Stop();

            MessageBox.Show(string.Format("Le temps écoulé" +
                "est de {0}",
                chrono.ElapsedMilliseconds));



        }
    }
}
