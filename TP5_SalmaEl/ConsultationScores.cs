using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using SqlLibrary;


namespace TP5_SalmaEl
{
    public partial class ConsultationScores : Form
    {

        ModuleDAO MDD = new ModuleDAO("module");
        EleveDAO E = new EleveDAO("eleves");
        MatiereDAO M = new MatiereDAO("matieres");
        NoteDAO ND = new NoteDAO("notes2021");
        SqlConnection con;
        SqlCommand cmd;

        //con = new MySqlConnection(@"server=localhost;user id=root;database=gestionnotes2021");
        // con.Open();
        //MySqlCommand cmd = new MySqlCommand();

        SqlDataReader dr;
        SqlCommand cd;




        public ConsultationScores()
        {
            InitializeComponent();
        }

        public ConsultationScores(string code)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source= DESKTOP-CMMGAAS\SQLEXPRESS; Initial Catalog = gestionnotes2021V2; Integrated Security = True");

            con.Open();
            cmd = new SqlCommand();

            CodeText.Text = code;
            CodeText.Enabled = false;
            lesMatiere(code);

        }




        private void lesMatiere(string code)   // pour charger les matieres qui etudie un etudiant! (a revoir !!)
        {

            ArrayList L = E.select(new RequestCondition("codeElev").Equal(code));
            foreach (Eleve V in L)
            {
                ArrayList F = MDD.select(new RequestCondition("Cod_Fil").Equal(V.Code_Fil));
                foreach (Module mod in F)
                {
                    ArrayList Mat = M.select(new RequestCondition("codeModule").Equal(mod.CodeModul));
                    foreach (Matiere MT in Mat)
                    {

                        string matiere = MT.CodeMat;
                        string mate = "";
                        ArrayList MatName = new MatiereDAO("matieres").selectmatieresNames(matiere);

                        foreach (string me in MatName)
                        {
                            mate += me;

                        }
                        MatiereCombo.Items.Add(mate);
                    }
                }
            }

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            string code = CodeText.Text;
            string matiere = MatiereCombo.Text;
            string mate = "";
            ArrayList MatName = new MatiereDAO("matieres").selectMatiereID(matiere);

            foreach (string me in MatName)
            {
                mate += me;

            }
            ArrayList L = ND.select(new RequestCondition("codeElev").Equal(code) + "and" + new RequestCondition("codeMat").Equal(mate));
            foreach (Note N in L)
            {
                NoteTexte.Text = N.Note1.ToString();
            }
        }
    }
}
