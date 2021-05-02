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
    public partial class ScoreForm : Form
    {
        ENSATDataContext dataDS = new ENSATDataContext();
        Guid ID = Guid.NewGuid();
        public ScoreForm()
        {
            InitializeComponent();
            /*get calculated score from previous Form*/
            ScoreBox.Text = QuestionForm.note.ToString();
            string IDmat = (from quiz in dataDS.Quizz
                         where quiz.IDquiz == QuizzMenu.IDquizz
                         select quiz.IDmat).FirstOrDefault();
            notes2021 note = new notes2021{ id = ID.ToString().Substring(0,6), codeElev= Acceuil.codeE,codeMat = IDmat, note = QuestionForm.note};

            try
            {
                dataDS.notes2021s.InsertOnSubmit(note);
                dataDS.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
