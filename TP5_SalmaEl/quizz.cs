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
    public partial class quizz : Form
    {
        ENSATDataContext data = new ENSATDataContext();
        Guid ID;
        int questionPosition = 1;
        string IdQuizz;

        public quizz()
        {
            InitializeComponent();
            question_panel.Visible = false;
            var profs = (from prof in data.Professeurs
                         select new { id = prof.ID, nom = prof.nomP }).ToList();

            prof_t.ValueMember = "id";
            prof_t.DisplayMember = "nom";
            prof_t.DataSource = profs;
            matiere_t.Enabled = false;
        }

        private void quizz_Load(object sender, EventArgs e)
        {

        }

        private void prof_t_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (prof_t.SelectedValue.ToString() != null)
            {
                var mats = (from m in data.matieres
                            where m.RespMat == prof_t.SelectedValue.ToString()
                            select new { id = m.codeMat, nom = m.designation }).ToList();

                matiere_t.ValueMember = "id";
                matiere_t.DisplayMember = "nom";

                if (mats.Count != 0)
                {
                    matiere_t.DataSource = mats;
                    matiere_t.Enabled = true;
                }
                else
                {
                    matiere_t.Enabled = false;
                    matiere_t.DataSource = null;
                }
            }

        }

        private void continuer_btn_Click(object sender, EventArgs e)
        {
            if (nom_t.Text == "" || prof_t.Text == "" || matiere_t.Text == "" || designation_t.Text == "")
            {
                MessageBox.Show("Impossible de continuer, remplissez tous les champs !!", "Erreur");
                return;
            }

            Quizz newQuizz = new Quizz
            {
                IDquiz = nom_t.Text,
                IDprof = prof_t.SelectedValue.ToString(),
                IDmat = matiere_t.SelectedValue.ToString(),
                Designation = designation_t.Text
            };

            try
            {
                data.Quizz.InsertOnSubmit(newQuizz);
                data.SubmitChanges();
                IdQuizz = newQuizz.IDquiz;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

            quizz_panel.Visible = false;
            quizz_name_label.Text = "Questions du Quizz : " + newQuizz.IDquiz;
            question_label.Text = "Question " + questionPosition + " :";
            question_panel.Visible = true;
        }

        private void suivant_btn_Click(object sender, EventArgs e)
        {
            if (question_t.Text == "" || poids_t.Text == "" || reponse1_t.Text == "" || reponse2_t.Text == "" || reponse3_t.Text == "" || reponse4_t.Text == "")
            {
                MessageBox.Show("Impossible de passer à la question suivante, remplissez tous les champs !!", "Erreur");
                return;
            }

            ID = Guid.NewGuid();

            QuestionT newQuestion = new QuestionT
            {
                IDquestion = ID.ToString().Substring(0, 6),
                IDquizz = this.IdQuizz,
                Question = question_t.Text,
                poids = float.Parse(poids_t.Text)
            };
            try
            {
                data.QuestionT.InsertOnSubmit(newQuestion);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

            ID = Guid.NewGuid();

            List<ReponseT> newReponses = new List<ReponseT>();
            newReponses.Add(new ReponseT {IDreponse = ID.ToString().Substring(0,5), IDquestion = newQuestion.IDquestion, Reponse = reponse1_t.Text, Statut = reponse1_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT {IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse2_t.Text, Statut = reponse2_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT {IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse3_t.Text, Statut = reponse3_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT {IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse4_t.Text, Statut = reponse4_check.Checked.ToString() });

            try
            {
                newReponses.ForEach(rep => data.ReponseT.InsertOnSubmit(rep));
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

            questionPosition++;
            question_t.Text = "";
            poids_t.Text = "";
            reponse1_t.Text = "Reponse1";
            reponse2_t.Text = "Reponse2";
            reponse3_t.Text = "Reponse3";
            reponse4_t.Text = "Reponse4";
            reponse1_check.Checked = false;
            reponse2_check.Checked = false;
            reponse3_check.Checked = false;
            reponse4_check.Checked = false;

            question_label.Text = "Question " + questionPosition + " :";
        }

        private void terminer_btn_Click(object sender, EventArgs e)
        {

            if (question_t.Text == "" || poids_t.Text == "" || reponse1_t.Text == "" || reponse2_t.Text == "" || reponse3_t.Text == "" || reponse4_t.Text == "")
            {
                MessageBox.Show("Impossible de passer à la question suivante, remplissez tous les champs !!", "Erreur");
                return;
            }

            ID = Guid.NewGuid();

            QuestionT newQuestion = new QuestionT
            {
                IDquestion = ID.ToString().Substring(0, 6),
                IDquizz = this.IdQuizz,
                Question = question_t.Text,
                poids = float.Parse(poids_t.Text)
            };
            try
            {
                data.QuestionT.InsertOnSubmit(newQuestion);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

            ID = Guid.NewGuid();

            List<ReponseT> newReponses = new List<ReponseT>();
            newReponses.Add(new ReponseT { IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse1_t.Text, Statut = reponse1_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT { IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse2_t.Text, Statut = reponse2_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT { IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse3_t.Text, Statut = reponse3_check.Checked.ToString() });
            ID = Guid.NewGuid();
            newReponses.Add(new ReponseT { IDreponse = ID.ToString().Substring(0, 5), IDquestion = newQuestion.IDquestion, Reponse = reponse4_t.Text, Statut = reponse4_check.Checked.ToString() });

            try
            {
                newReponses.ForEach(rep => data.ReponseT.InsertOnSubmit(rep));
                data.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

            MessageBox.Show("le quizz " + nom_t.Text + " de matiere " + matiere_t.Text + " est bien creer", "Information");
        }
    }
}
