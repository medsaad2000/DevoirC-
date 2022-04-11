using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtudiantDataDevoir
{
    public partial class Form2 : Form
    {

        public Etudiant etudiant;
        public String name;
        public String id;
        public String niveau;

        public Etudiant getEtudiant() { 
            return this.etudiant;
        }
        public Form2()
        {
            InitializeComponent();
            etudiant = new Etudiant();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            etudiant.setId(txtId.Text);
            etudiant.setNom(txtNom.Text);
            etudiant.setNiveau(txtNiveau.Text);
            
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(niveau);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
