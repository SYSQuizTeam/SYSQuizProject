using System;
using System.Collections;
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
        /* Get the index of selected quizz from the previous Form */
        string idQuiz = QuizzMenu.IDquizz;
        /* Set a counter to count the number of questions */
        public int CountQuestion = 0;
        public double poids = 0;
        /* Set note to count the total score of the quiz */
        public static List<double> score = new List<double>();
        public List<double> notes=new List<double>();
        public QuestionForm()
        {

            InitializeComponent();
            LoadQuestion(questionIndex);
            /*Count Number of Questions */
            CountQuestion = (from question in dataDS.QuestionT
                                 where question.IDquizz == idQuiz
                                 select question).Count();

            /* Get the designiqtion of the quizz */
            string quizDesigniation = (from quiz in dataDS.Quizz
                                       where quiz.IDquiz == idQuiz
                                       select quiz.Designation).FirstOrDefault();
            designiationQuiz.Text = quizDesigniation;

        }

        /* Function that get all answers by index of question */
        public List<ReponseT> LoadAnswers(int index)
        {
            /*Get all questions of selected quiz*/
            var questions = (from question in dataDS.QuestionT
                             where question.IDquizz == idQuiz
                             select question).ToList();

            /*Get question by index */
            var q = questions.ElementAt(index);
            QuestionQuiz.Text = q.Question;
            poids = Convert.ToDouble(q.poids);

            /*Get all answers of the selected question*/
            var Reponses = (from reponse in dataDS.ReponseT
                            where reponse.IDquestion == q.IDquestion
                            select reponse).ToList();
            return Reponses;
        }

        public void LoadQuestion(int index)
        {
            /*Load Answers*/
            List<ReponseT> Reponses = LoadAnswers(index);

            reponse1.Text = Reponses.ElementAt(0).Reponse;
            reponse2.Text = Reponses.ElementAt(1).Reponse;
            reponse3.Text = Reponses.ElementAt(2).Reponse;
            reponse4.Text = Reponses.ElementAt(3).Reponse;

        }

        /* Get user Answer and calculate the score*/
        public void GetAnswer(int index)
        {
            List<ReponseT> Reponses = LoadAnswers(index);

            string statut = "";
            /* Get the statut of choosen answer*/
            if (radioButton1.Checked == true) statut = Reponses.ElementAt(0).Statut;
            else if (radioButton2.Checked == true) statut = Reponses.ElementAt(1).Statut;
            else if (radioButton3.Checked == true) statut = Reponses.ElementAt(2).Statut;
            else if (radioButton4.Checked == true) statut = Reponses.ElementAt(3).Statut;
            /*calculate score */
            if (statut == "True")
            {
                notes.Insert(index, poids);
            }
            else if (statut == "False")
            {
                notes.Insert(index, 0);
            }
            /*Reset radio Buttons*/
            foreach (Control c in this.Controls)
            {
                if (c is RadioButton) ((RadioButton)c).Checked = false;
            }
        }

        private void NextQuestionBTN_Click(object sender, EventArgs e)
        {
            GetAnswer(questionIndex);
            /* When the button next is clicked increment the value of questionindex 
             to get the next question until questionIndex eqauls question counter - 1 */
            questionIndex++;

            if (questionIndex < CountQuestion)
            {
                LoadQuestion(questionIndex);
            }
            /* Once we show all questions we show the next Form to display score and store it in the DB */
            else
            {
                this.Hide();
                score = notes;
                ScoreForm scoreForm = new ScoreForm();
                scoreForm.Show();
            }
        }

        /* get previous question */
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            /*Get current index */
            int index = questionIndex;
            if (index > 0) { 
                questionIndex--;
                /*Load prvious question */
                LoadQuestion(questionIndex);
                notes.RemoveAt(questionIndex);
            }
        }

    }


 }
