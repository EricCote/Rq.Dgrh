using Rq.Dgrh.LaZone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

     

        private void btnAjouterEmployes_Click(object sender, EventArgs e)
        {
            Employe emp1 = new Employe("Michael", new DateTime(2012, 01, 01), 95000);
            Employe emp2 = new Employe("Jean-Marc", new DateTime(2012, 01, 01), 96000);
            Employe emp3 = new Employe("Antouane", new DateTime(2012, 01, 01), 97000);
            Employe emp4 = new Employe("Samuel", new DateTime(2012, 01, 01), 97000);
            Employe emp5 = new Employe("Gabriel", new DateTime(2012, 01, 01), 98000);
            Patron pat1 = new Patron("Marc", new DateTime(2015, 01, 01), 100000, 5001);

            emp1.Display += (msg) => MessageBox.Show(msg);
            emp2.Display += (msg) => MessageBox.Show(msg);
            emp3.Display += (msg) => MessageBox.Show(msg);
            emp4.Display += (msg) => MessageBox.Show(msg);
            emp5.Display += Console.WriteLine;
            pat1.Display += (msg) => MessageBox.Show(msg);

            Employes.AddRange(new Employe[] {emp1,emp2,emp3,emp4,emp5,pat1});
            rafraichir2();
        }

        private void btnMasseSalariale_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Employe emp in Employes)
            {         
                total += emp.Salaire ;
                if (emp is Patron)
                {
                    total += ((Patron)emp).Bonus;
                }
                //Patron pat = emp as Patron;
                //total += pat?.Bonus ?? 0;
            }
            MessageBox.Show(String.Format(
                "La masse salariale de {0} est {1:c0}", 
                Employe.NomCompagnie, total));

        }

        private void btnBienPaye_Click(object sender, EventArgs e)
        {
            int nb = 98000;
            foreach (Employe emp in Employes.
                Where((emp) => emp.Salaire > nb ))
            { MessageBox.Show(emp.Nom); }

            //For Each emp as Employe in Employes.
            //  Where(Function(emp1) emp1.Salaire > 98000))
        }
    }
}
