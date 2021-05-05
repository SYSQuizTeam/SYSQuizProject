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
    public partial class gestionQuizz : Form
    {
        ENSATDataContext data = new ENSATDataContext();
        string quizzName;
        int QuestionPos;
        List<QuestionT> questions;
        string IdProf;

        public gestionQuizz(string IdProf)
        {
            InitializeComponent();
            question_panel.Visible = false;

            this.IdProf = IdProf;

            var LesQuizz = from q in data.Quizz
                           where q.IDprof == this.IdProf
                           select q.IDquiz;

            quizz_t.DataSource = LesQuizz;

            QuestionPos = 1;
        }

        private void continuer_btn_Click(object sender, EventArgs e)
        {
            if (quizz_t.Text != "")
            {
                quizzName = quizz_t.Text;
                quizz_name_label.Text = "Questions du Quizz : " + quizzName;
                question_label.Text = "Question " + QuestionPos;

                gestion_quizz_panel.Visible = false;
                question_panel.Visible = true;

                precedent_btn.Visible = false;

                getData();

                if (questions.Count == 1)
                {
                    suivant_btn.Visible = false;
                }

                if (questions.Count > 0)
                {
                    var reps = (from r in data.ReponseT
                                where r.IDquestion == questions[QuestionPos - 1].IDquestion
                                select r).ToList();

                    question_t.Text = questions[QuestionPos - 1].Question.ToString();
                    poids_t.Text = questions[QuestionPos - 1].poids.ToString();

                    reponse1_t.Text = reps[0].Reponse.ToString();
                    reponse1_check.Checked = bool.Parse(reps[0].Statut.ToString());

                    reponse2_t.Text = reps[1].Reponse.ToString();
                    reponse2_check.Checked = bool.Parse(reps[1].Statut.ToString());

                    reponse3_t.Text = reps[2].Reponse.ToString();
                    reponse3_check.Checked = bool.Parse(reps[2].Statut.ToString());

                    reponse4_t.Text = reps[3].Reponse.ToString();
                    reponse4_check.Checked = bool.Parse(reps[3].Statut.ToString());
                }
                else
                {
                    question_panel.Visible = false;
                    MessageBox.Show("Cet quizz n'a aucune question", "Ouups!");
                }

            }
        }

        public void getData()
        {
            questions = (from q in data.QuestionT
                         where q.IDquizz.ToString() == quizz_t.Text
                         select q).ToList();
        }

        private void suivant_btn_Click(object sender, EventArgs e)
        {
            precedent_btn.Visible = true;
            QuestionPos++;

            if (QuestionPos == questions.Count)
            {
                suivant_btn.Visible = false;
            }

            question_label.Text = "Question " + QuestionPos;

            var reps = (from r in data.ReponseT
                        where r.IDquestion == questions[QuestionPos - 1].IDquestion
                        select r).ToList();

            question_t.Text = questions[QuestionPos - 1].Question.ToString();
            poids_t.Text = questions[QuestionPos - 1].poids.ToString();

            reponse1_t.Text = reps[0].Reponse.ToString();
            reponse1_check.Checked = bool.Parse(reps[0].Statut.ToString());

            reponse2_t.Text = reps[1].Reponse.ToString();
            reponse2_check.Checked = bool.Parse(reps[1].Statut.ToString());

            reponse3_t.Text = reps[2].Reponse.ToString();
            reponse3_check.Checked = bool.Parse(reps[2].Statut.ToString());

            reponse4_t.Text = reps[3].Reponse.ToString();
            reponse4_check.Checked = bool.Parse(reps[3].Statut.ToString());
        }

        private void precedent_btn_Click(object sender, EventArgs e)
        {
            QuestionPos--;

            if (!suivant_btn.Visible)
            {
                suivant_btn.Visible = true;
            }

            if (QuestionPos == 1)
            {
                precedent_btn.Visible = false;
            }
            question_label.Text = "Question " + QuestionPos;

            var reps = (from r in data.ReponseT
                        where r.IDquestion == questions[QuestionPos - 1].IDquestion
                        select r).ToList();

            question_t.Text = questions[QuestionPos - 1].Question.ToString();
            poids_t.Text = questions[QuestionPos - 1].poids.ToString();

            reponse1_t.Text = reps[0].Reponse.ToString();
            reponse1_check.Checked = bool.Parse(reps[0].Statut.ToString());

            reponse2_t.Text = reps[1].Reponse.ToString();
            reponse2_check.Checked = bool.Parse(reps[1].Statut.ToString());

            reponse3_t.Text = reps[2].Reponse.ToString();
            reponse3_check.Checked = bool.Parse(reps[2].Statut.ToString());

            reponse4_t.Text = reps[3].Reponse.ToString();
            reponse4_check.Checked = bool.Parse(reps[3].Statut.ToString());
        }

        private void modifier_qst_btn_Click(object sender, EventArgs e)
        {
            if (question_t.Text != "" && poids_t.Text != "")
            {
                var qst = (from q in data.QuestionT
                           where q.IDquestion == questions[QuestionPos - 1].IDquestion
                           select q).FirstOrDefault();

                // Modifier la data dans la base de données
                qst.Question = question_t.Text;
                qst.poids = float.Parse(poids_t.Text);

                data.SubmitChanges();

                // Modifier la data dans la LISTE qui contient les questions 
                questions[QuestionPos - 1].Question = question_t.Text;
                questions[QuestionPos - 1].poids = float.Parse(poids_t.Text);

                MessageBox.Show("La Question a été bien modifier", "Modification");
            }
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez vous supprimer cette question ?", "Attention");
            if (dr == DialogResult.OK)
            {
                // supression des reponses lié à cette question :
                var reps = from r in data.ReponseT
                           where r.IDquestion == questions[QuestionPos - 1].IDquestion
                           select r;

                data.ReponseT.DeleteAllOnSubmit(reps);
                data.SubmitChanges();

                //suppression de la question :
                var qst = (from q in data.QuestionT
                           where q.IDquestion == questions[QuestionPos - 1].IDquestion
                           select q).FirstOrDefault();

                data.QuestionT.DeleteOnSubmit(qst);
                data.SubmitChanges();

                // suppression de la question du LISTE "questions" qui contient les qsts :
                questions.RemoveAt(QuestionPos - 1);

                if (questions.Count > 0)
                {
                    // visualisation de la question qui précéde la qst supprimer

                    if (QuestionPos == 1)
                    {
                        if (questions.Count != 1)
                        {
                            QuestionPos++;
                        }
                    }
                    else
                    {
                        QuestionPos--;
                    }

                    if (QuestionPos == 1)
                    {
                        precedent_btn.Visible = false;
                    }

                    question_label.Text = "Question " + QuestionPos;

                    var repss = (from r in data.ReponseT
                                 where r.IDquestion == questions[QuestionPos - 1].IDquestion
                                 select r).ToList();

                    question_t.Text = questions[QuestionPos - 1].Question.ToString();
                    poids_t.Text = questions[QuestionPos - 1].poids.ToString();

                    reponse1_t.Text = repss[0].Reponse.ToString();
                    reponse1_check.Checked = bool.Parse(repss[0].Statut.ToString());

                    reponse2_t.Text = repss[1].Reponse.ToString();
                    reponse2_check.Checked = bool.Parse(repss[1].Statut.ToString());

                    reponse3_t.Text = repss[2].Reponse.ToString();
                    reponse3_check.Checked = bool.Parse(repss[2].Statut.ToString());

                    reponse4_t.Text = repss[3].Reponse.ToString();
                    reponse4_check.Checked = bool.Parse(repss[3].Statut.ToString());

                }

                else
                {
                    MessageBox.Show("Toute les questions sont supprimer", "Oupps");
                    gestion_quizz_panel.Visible = true;
                    question_panel.Visible = false;
                }

            }
        }

        private void supprQuizz_btn_Click(object sender, EventArgs e)
        {

            // il faut supprimer tout d'abord les reponses puis les questions puis le quizz

            var quests = from q in data.QuestionT
                         where q.IDquizz == quizz_t.Text
                         select q;

            foreach (var quest in quests)
            {

                var reps = from r in data.ReponseT
                           where r.IDquestion == quest.IDquestion
                           select r;

                //suppression des reponses de la question quest
                data.ReponseT.DeleteAllOnSubmit(reps);
                data.SubmitChanges();

                //suppression de la question quest
                data.QuestionT.DeleteOnSubmit(quest);
                data.SubmitChanges();
            }

            //suppression du quizz

            var quiz = (from q in data.Quizz
                        where q.IDquiz == quizz_t.Text
                        select q).First();

            data.Quizz.DeleteOnSubmit(quiz);
            data.SubmitChanges();

            MessageBox.Show("Quizz " + quizz_t.Text + " est bien supprimé", "INFO");

            //modifier le combobox qui contient les quizz:

            var LesQuizz = from q in data.Quizz
                           where q.IDprof == this.IdProf
                           select q.IDquiz;

            quizz_t.DataSource = LesQuizz;
        }
    }
}
