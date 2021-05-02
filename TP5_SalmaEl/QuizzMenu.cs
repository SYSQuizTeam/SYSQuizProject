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
    public partial class QuizzMenu : Form
    {
        
        public static string IDquizz = "";
        ENSATDataContext dataDS = new ENSATDataContext();
        public QuizzMenu()
        {
            InitializeComponent();
            /* get a list of all Quizz */
            var quizz = (from quiz in dataDS.Quizz
                         select new { id = quiz.IDquiz, designiation = quiz.Designation }).ToList();

            QuizzList.ValueMember = "id";
            QuizzList.DisplayMember = "designiation";
            QuizzList.DataSource = quizz;
        }



        private void QuizMenuBTN_Click(object sender, EventArgs e)
        {
            /*Store the id of selected quizz to send it to the next form*/ 
            IDquizz = QuizzList.SelectedValue.ToString();
            this.Hide();
            QuestionForm.questionIndex = 0;
            
            QuestionForm questionForm = new QuestionForm();
            questionForm.Show();
        }
    }
}
