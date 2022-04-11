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
    public partial class Form1 : Form
    {
        Form2 form2;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.ShowDialog();
            
            dataGridView1.Rows.Add(form.getEtudiant().getId(), form.getEtudiant().getNom(), form.getEtudiant().getNiveau());

            
            /*
            using (Form2 form = new Form2() { })
            {

                Console.WriteLine(form.niveau);

                if (form2.ShowDialog() == DialogResult.OK)
                {
                     dataGridView1.Rows.Add(form2.getEtudiant().getId(),form2.getEtudiant().getNom(),form2.getEtudiant().getNiveau());
                    //dataGridView1.Rows.Add(form.id, form.Name, form.niveau);
                }

                
            }
            */
        }
    }
}
