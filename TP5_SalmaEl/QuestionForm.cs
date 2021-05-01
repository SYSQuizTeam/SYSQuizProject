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
    public partial class QuestionForm : Form
    {
        public static int questionIndex = 0;
        ENSATDataContext dataDS = new ENSATDataContext();
        /* get the index of selected quizz from the previous Form */
        string idQuiz = QuizzMenu.IDquizz;
        /* set a counter to count the number of questions */
        public int CountQuestion = 0;
        public QuestionForm()
        {
            InitializeComponent();
            LoadQuestion(questionIndex);
            /*count Number of Questions */
            CountQuestion = (from question in dataDS.QuestionT
                                 where question.IDquizz == idQuiz
                                 select question).Count();
            /* get the designiqtion of the quizz */
            string quizDesigniation = (from quiz in dataDS.Quizz
                                       where quiz.IDquiz == idQuiz
                                       select quiz.Designation).FirstOrDefault();
            designiationQuiz.Text = quizDesigniation;

        }
        public void LoadQuestion(int index)
        {
            /*get all questions of selected quiz*/
            var questions = (from question in dataDS.QuestionT
                             where question.IDquizz == idQuiz
                             select question).ToList();

            /*get question by index */
            var q = questions.ElementAt(questionIndex);
            QuestionQuiz.Text = q.Question;

            /*get all answers of the selected question*/
            var Reponses = (from reponse in dataDS.ReponseT
                            where reponse.IDquestion == q.IDquestion
                            select reponse).ToList();

            reponse1.Text = Reponses.ElementAt(0).Reponse;
            reponse2.Text = Reponses.ElementAt(1).Reponse;
            reponse3.Text = Reponses.ElementAt(2).Reponse;
            reponse4.Text = Reponses.ElementAt(3).Reponse;
        }


        private void NextQuestionBTN_Click(object sender, EventArgs e)
        {
            /* when the button next is clicked increment the value
             of questionindex to get the next question until questionIndex eqauls question counter - 1 */
            questionIndex++;
            if (questionIndex < CountQuestion)
            {
                LoadQuestion(questionIndex);
            }
            /* once we show all questions we show the next Form to display score and store it in the DB */
            else
            {
                this.Hide();
                ScoreForm scoreForm = new ScoreForm();
                scoreForm.Show();
            }
        }
    }


 }
