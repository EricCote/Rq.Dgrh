using Rq.Dgrh.LaZone;
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
    public partial class frmEmployes : Form
    {
        List<Employe> Employes = new List<Employe>();  

        public frmEmployes()
        {
            InitializeComponent();
        }




        private void btnAjoutEmploye_Click(object sender, EventArgs e)
        {
            Employe emp = new Employe(txtNom.Text, 
                                      DateTime.Parse(txtEmbauche.Text), 
                                      int.Parse(txtSalaire.Text));
            Employes.Add(emp);

            rafraichir2();
        }

        private void rafraichir2()
        {
            CurrencyManager cm = 
                (CurrencyManager)this.BindingContext[Employes];
            cm.Refresh();
        }

        private void rafraichir()
        {
            lstEmployes.Items.Clear();
            foreach (Employe emp in Employes)
            {
                lstEmployes.Items.Add(emp.Nom);
            }
        }

        private void frmEmployes_Load(object sender, EventArgs e)
        {
            lstEmployes.DataSource = Employes;
            lstEmployes.DisplayMember = "Nom";
        }

        private void lstEmployes_DoubleClick(object sender, EventArgs e)
        {
            ((Employe)lstEmployes.SelectedItem).Afficher();
        }
    }
}
