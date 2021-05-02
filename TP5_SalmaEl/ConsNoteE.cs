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
    public partial class ConsNoteE : Form
    {
        ENSATDataContext dataDS = new ENSATDataContext();
        public ConsNoteE()
        {
            var getNotes = (from note in dataDS.notes2021s
                            where note.codeElev == Acceuil.codeE
                            select note
                          ).ToList();
            dataGridView1.DataSource = getNotes;
            InitializeComponent();
        }


    }
}
