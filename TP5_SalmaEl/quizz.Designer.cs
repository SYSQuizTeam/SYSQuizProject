
namespace TP5_SalmaEl
{
    partial class quizz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quizz_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prof_t = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matiere_t = new System.Windows.Forms.ComboBox();
            this.nom_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.designation_t = new System.Windows.Forms.TextBox();
            this.continuer_btn = new System.Windows.Forms.Button();
            this.question_panel = new System.Windows.Forms.Panel();
            this.suivant_btn = new System.Windows.Forms.Button();
            this.terminer_btn = new System.Windows.Forms.Button();
            this.reponse4_check = new System.Windows.Forms.CheckBox();
            this.reponse3_check = new System.Windows.Forms.CheckBox();
            this.reponse2_check = new System.Windows.Forms.CheckBox();
            this.reponse1_check = new System.Windows.Forms.CheckBox();
            this.reponse4_t = new System.Windows.Forms.TextBox();
            this.reponse3_t = new System.Windows.Forms.TextBox();
            this.reponse2_t = new System.Windows.Forms.TextBox();
            this.reponse1_t = new System.Windows.Forms.TextBox();
            this.poids_t = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.question_t = new System.Windows.Forms.TextBox();
            this.question_label = new System.Windows.Forms.Label();
            this.quizz_name_label = new System.Windows.Forms.Label();
            this.quizz_panel.SuspendLayout();
            this.question_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizz_panel
            // 
            this.quizz_panel.Controls.Add(this.button1);
            this.quizz_panel.Controls.Add(this.label1);
            this.quizz_panel.Controls.Add(this.prof_t);
            this.quizz_panel.Controls.Add(this.label3);
            this.quizz_panel.Controls.Add(this.label5);
            this.quizz_panel.Controls.Add(this.matiere_t);
            this.quizz_panel.Controls.Add(this.nom_t);
            this.quizz_panel.Controls.Add(this.label2);
            this.quizz_panel.Controls.Add(this.label4);
            this.quizz_panel.Controls.Add(this.designation_t);
            this.quizz_panel.Controls.Add(this.continuer_btn);
            this.quizz_panel.Location = new System.Drawing.Point(32, 21);
            this.quizz_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizz_panel.Name = "quizz_panel";
            this.quizz_panel.Size = new System.Drawing.Size(530, 310);
            this.quizz_panel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Gestion des Quizz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau Quizz :";
            // 
            // prof_t
            // 
            this.prof_t.FormattingEnabled = true;
            this.prof_t.Location = new System.Drawing.Point(223, 139);
            this.prof_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prof_t.Name = "prof_t";
            this.prof_t.Size = new System.Drawing.Size(126, 21);
            this.prof_t.TabIndex = 10;
            this.prof_t.SelectedIndexChanged += new System.EventHandler(this.prof_t_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matiere : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Professeur: ";
            // 
            // matiere_t
            // 
            this.matiere_t.FormattingEnabled = true;
            this.matiere_t.Location = new System.Drawing.Point(223, 176);
            this.matiere_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matiere_t.Name = "matiere_t";
            this.matiere_t.Size = new System.Drawing.Size(126, 21);
            this.matiere_t.TabIndex = 3;
            // 
            // nom_t
            // 
            this.nom_t.Location = new System.Drawing.Point(223, 103);
            this.nom_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nom_t.Name = "nom_t";
            this.nom_t.Size = new System.Drawing.Size(126, 20);
            this.nom_t.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Designation : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom : ";
            // 
            // designation_t
            // 
            this.designation_t.Location = new System.Drawing.Point(223, 214);
            this.designation_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.designation_t.Name = "designation_t";
            this.designation_t.Size = new System.Drawing.Size(126, 20);
            this.designation_t.TabIndex = 5;
            // 
            // continuer_btn
            // 
            this.continuer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuer_btn.Location = new System.Drawing.Point(170, 262);
            this.continuer_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continuer_btn.Name = "continuer_btn";
            this.continuer_btn.Size = new System.Drawing.Size(142, 26);
            this.continuer_btn.TabIndex = 6;
            this.continuer_btn.Text = "Continuer";
            this.continuer_btn.UseVisualStyleBackColor = true;
            this.continuer_btn.Click += new System.EventHandler(this.continuer_btn_Click);
            // 
            // question_panel
            // 
            this.question_panel.Controls.Add(this.suivant_btn);
            this.question_panel.Controls.Add(this.terminer_btn);
            this.question_panel.Controls.Add(this.reponse4_check);
            this.question_panel.Controls.Add(this.reponse3_check);
            this.question_panel.Controls.Add(this.reponse2_check);
            this.question_panel.Controls.Add(this.reponse1_check);
            this.question_panel.Controls.Add(this.reponse4_t);
            this.question_panel.Controls.Add(this.reponse3_t);
            this.question_panel.Controls.Add(this.reponse2_t);
            this.question_panel.Controls.Add(this.reponse1_t);
            this.question_panel.Controls.Add(this.poids_t);
            this.question_panel.Controls.Add(this.label8);
            this.question_panel.Controls.Add(this.label7);
            this.question_panel.Controls.Add(this.question_t);
            this.question_panel.Controls.Add(this.question_label);
            this.question_panel.Controls.Add(this.quizz_name_label);
            this.question_panel.Location = new System.Drawing.Point(49, -1);
            this.question_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(487, 357);
            this.question_panel.TabIndex = 17;
            // 
            // suivant_btn
            // 
            this.suivant_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.Location = new System.Drawing.Point(328, 317);
            this.suivant_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suivant_btn.Name = "suivant_btn";
            this.suivant_btn.Size = new System.Drawing.Size(106, 28);
            this.suivant_btn.TabIndex = 15;
            this.suivant_btn.Text = "Suivant";
            this.suivant_btn.UseVisualStyleBackColor = true;
            this.suivant_btn.Click += new System.EventHandler(this.suivant_btn_Click);
            // 
            // terminer_btn
            // 
            this.terminer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminer_btn.Location = new System.Drawing.Point(135, 317);
            this.terminer_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terminer_btn.Name = "terminer_btn";
            this.terminer_btn.Size = new System.Drawing.Size(106, 28);
            this.terminer_btn.TabIndex = 14;
            this.terminer_btn.Text = "Terminer";
            this.terminer_btn.UseVisualStyleBackColor = true;
            this.terminer_btn.Click += new System.EventHandler(this.terminer_btn_Click);
            // 
            // reponse4_check
            // 
            this.reponse4_check.AutoSize = true;
            this.reponse4_check.Location = new System.Drawing.Point(276, 268);
            this.reponse4_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse4_check.Name = "reponse4_check";
            this.reponse4_check.Size = new System.Drawing.Size(15, 14);
            this.reponse4_check.TabIndex = 13;
            this.reponse4_check.UseVisualStyleBackColor = true;
            // 
            // reponse3_check
            // 
            this.reponse3_check.AutoSize = true;
            this.reponse3_check.Location = new System.Drawing.Point(276, 232);
            this.reponse3_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse3_check.Name = "reponse3_check";
            this.reponse3_check.Size = new System.Drawing.Size(15, 14);
            this.reponse3_check.TabIndex = 12;
            this.reponse3_check.UseVisualStyleBackColor = true;
            // 
            // reponse2_check
            // 
            this.reponse2_check.AutoSize = true;
            this.reponse2_check.Location = new System.Drawing.Point(276, 197);
            this.reponse2_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse2_check.Name = "reponse2_check";
            this.reponse2_check.Size = new System.Drawing.Size(15, 14);
            this.reponse2_check.TabIndex = 11;
            this.reponse2_check.UseVisualStyleBackColor = true;
            // 
            // reponse1_check
            // 
            this.reponse1_check.AutoSize = true;
            this.reponse1_check.Location = new System.Drawing.Point(276, 163);
            this.reponse1_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse1_check.Name = "reponse1_check";
            this.reponse1_check.Size = new System.Drawing.Size(15, 14);
            this.reponse1_check.TabIndex = 10;
            this.reponse1_check.UseVisualStyleBackColor = true;
            // 
            // reponse4_t
            // 
            this.reponse4_t.Location = new System.Drawing.Point(53, 265);
            this.reponse4_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse4_t.Name = "reponse4_t";
            this.reponse4_t.Size = new System.Drawing.Size(179, 20);
            this.reponse4_t.TabIndex = 9;
            this.reponse4_t.Text = "Réponse 4";
            // 
            // reponse3_t
            // 
            this.reponse3_t.Location = new System.Drawing.Point(53, 229);
            this.reponse3_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse3_t.Name = "reponse3_t";
            this.reponse3_t.Size = new System.Drawing.Size(179, 20);
            this.reponse3_t.TabIndex = 8;
            this.reponse3_t.Text = "Réponse 3";
            // 
            // reponse2_t
            // 
            this.reponse2_t.Location = new System.Drawing.Point(53, 194);
            this.reponse2_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse2_t.Name = "reponse2_t";
            this.reponse2_t.Size = new System.Drawing.Size(179, 20);
            this.reponse2_t.TabIndex = 7;
            this.reponse2_t.Text = "Réponse 2";
            // 
            // reponse1_t
            // 
            this.reponse1_t.Location = new System.Drawing.Point(53, 160);
            this.reponse1_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reponse1_t.Name = "reponse1_t";
            this.reponse1_t.Size = new System.Drawing.Size(179, 20);
            this.reponse1_t.TabIndex = 6;
            this.reponse1_t.Text = "Réponse 1";
            // 
            // poids_t
            // 
            this.poids_t.Location = new System.Drawing.Point(384, 75);
            this.poids_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.poids_t.Name = "poids_t";
            this.poids_t.Size = new System.Drawing.Size(52, 20);
            this.poids_t.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "poids";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Réponses : (cochez celle qui est juste)";
            // 
            // question_t
            // 
            this.question_t.Location = new System.Drawing.Point(112, 73);
            this.question_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question_t.Name = "question_t";
            this.question_t.Size = new System.Drawing.Size(179, 20);
            this.question_t.TabIndex = 2;
            this.question_t.TextChanged += new System.EventHandler(this.question_t_TextChanged);
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.Location = new System.Drawing.Point(23, 73);
            this.question_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(73, 17);
            this.question_label.TabIndex = 1;
            this.question_label.Text = "Question";
            // 
            // quizz_name_label
            // 
            this.quizz_name_label.AutoSize = true;
            this.quizz_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizz_name_label.Location = new System.Drawing.Point(167, 17);
            this.quizz_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizz_name_label.Name = "quizz_name_label";
            this.quizz_name_label.Size = new System.Drawing.Size(168, 18);
            this.quizz_name_label.TabIndex = 0;
            this.quizz_name_label.Text = "Questions du quizz : ";
            // 
            // quizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.question_panel);
            this.Controls.Add(this.quizz_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "quizz";
            this.Text = "quizz";
            this.Load += new System.EventHandler(this.quizz_Load);
            this.quizz_panel.ResumeLayout(false);
            this.quizz_panel.PerformLayout();
            this.question_panel.ResumeLayout(false);
            this.question_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel quizz_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prof_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox matiere_t;
        private System.Windows.Forms.TextBox nom_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designation_t;
        private System.Windows.Forms.Button continuer_btn;
        private System.Windows.Forms.Panel question_panel;
        private System.Windows.Forms.Button suivant_btn;
        private System.Windows.Forms.Button terminer_btn;
        private System.Windows.Forms.CheckBox reponse4_check;
        private System.Windows.Forms.CheckBox reponse3_check;
        private System.Windows.Forms.CheckBox reponse2_check;
        private System.Windows.Forms.CheckBox reponse1_check;
        private System.Windows.Forms.TextBox reponse4_t;
        private System.Windows.Forms.TextBox reponse3_t;
        private System.Windows.Forms.TextBox reponse2_t;
        private System.Windows.Forms.TextBox reponse1_t;
        private System.Windows.Forms.TextBox poids_t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox question_t;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label quizz_name_label;
    }
}