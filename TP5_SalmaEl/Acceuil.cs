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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {


            //recuperer le code de l'etudiant ou du professeur
            string code = CodeTxt.Text;

            ENSATDataContext linqDB;
            linqDB = new ENSATDataContext();

            if(linqDB.eleves.Any(u => u.codeElev == code))  //if (( from u in linqDB.eleves WHERE u.codeElev == code select u).Any()
            {
                // Code is a code of a student


                //Recuperer les information sur l etudiant

                string c = (from u in linqDB.eleves where u.codeElev == code select u.codeElev).Single();
                string nom = (from u in linqDB.eleves where u.codeElev == code select u.nom).Single();
                string prenom = (from u in linqDB.eleves where u.codeElev == code select u.prenom).Single();
                string filiere = (from u in linqDB.eleves where u.codeElev == code select u.code_Fil).Single();
                string niveau = (from u in linqDB.eleves where u.codeElev == code select u.niveau).Single();
               

                //Open Student View

                
                MenuE f2 = new MenuE(c,nom,prenom,filiere,niveau);
                   
                    f2.Show();
              

            }

            else if(linqDB.Professeurs.Any(u => u.ID == code))
            {
                // The typed code is a code of a Teacher

                //Recuperer les information sur l Professeur

                string nom = (from u in linqDB.Professeurs where u.ID == code select u.nomP).Single();
                string prenom = (from u in linqDB.Professeurs where u.ID == code select u.prenomP).Single();
                string IdProf = (from u in linqDB.Professeurs where u.ID == code select u.ID).Single();


                // Open Teacher View

                /* foreach (Form f in Application.OpenForms)
                 {
                     if (f.Text == "MenuP")
                     {
                         IsOpen = true;
                         f.Focus();
                         break;
                     }
                 }

                 if (IsOpen == false)
                 {*/
                MenuP f2 = new MenuP(nom,prenom, IdProf);
                  //  f2.MdiParent = this;
                    f2.Show();
                //}
            }

            else
            {
                // The typed code is not a code of a student and not a code of a teacher

                MessageBox.Show("ce Code n existe pas dans ENSAT ! ");
            }


           




          
        }
    }
}
