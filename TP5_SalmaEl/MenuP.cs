using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    public partial class MenuP : Form
    {
        public MenuP(string nom,string prenom)
        {
            InitializeComponent();
            label5.Text = nom;
            label6.Text = prenom;
        }

        //Hide Professor acceuil Info
        public void HideAcceuilInfo()
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            NameProf.Text = "";
            label9.Text = "";
            label10.Text = "";
          
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hide Professor acceuil Info
            HideAcceuilInfo();



            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestionEtudiantForm")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestionEtudiantForm f2 = new GestionEtudiantForm();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide Professor acceuil Info
            HideAcceuilInfo();


            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Consultation Des Notes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Consultation_Des_Notes f2 = new Consultation_Des_Notes();
                f2.MdiParent = this;
                f2.Show();
            }
        }




        private void filièresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hide Professor acceuil Info
            HideAcceuilInfo();


            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestionFilieres")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestionFilieres f2 = new GestionFilieres();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void matièresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hide Professor acceuil Info
            HideAcceuilInfo();


            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestionAllMatieres")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestionAllMatieres f2 = new GestionAllMatieres();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hide Professor acceuil Info
            HideAcceuilInfo();


            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestionModules")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestionModules f2 = new GestionModules();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Hide Professor acceuil Info
            HideAcceuilInfo();


            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Bilan Annuel")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Bilan_Annuel f2 = new Bilan_Annuel();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
