﻿using System;
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
        public ScoreForm()
        {
            InitializeComponent();
            ScoreBox.Text = QuestionForm.note.ToString();
        }

    }
}
