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
    public partial class frmTesteurMusique : Form
    {
        public frmTesteurMusique()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            LecteurCd cd = new LecteurCd();
            TesterLecteur(cd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecteurMp3 mp3 = new LecteurMp3();
            TesterLecteur(mp3);
        }

        void TesterLecteur(ILecteur lecteur)
        {
            lecteur.Play(1);
            lecteur.Play(2);
            lecteur.Stop();
        }
    }
}
