using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_SalmaEl
{
    public partial class MenuE : Form
    {
        public MenuE(string code, string name,string prenom, string filiere,string niveau)
        {
            InitializeComponent();
            label12.Text = code;
            label5.Text = name;
            label6.Text = prenom;
            label7.Text = filiere;
            label8.Text = niveau;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void HideAcceuilInfo()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Hide();
            NameStudent.Text = "";
        }



        private void passAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide Acceuil Informations 
            HideAcceuilInfo();

            //Open Pass a Quiz Window
            QuizzMenu FormQuizz = new QuizzMenu();
            FormQuizz.Show();
        }

        private void consultationNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide Acceuil Informations 
            HideAcceuilInfo();


            //Open Consultation Note Window

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestionNotes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                ConsultationScores GN = new ConsultationScores(label12.Text);
              //  GN.MdiParent = this;
                GN.Show();
            }
        }
    }
}
