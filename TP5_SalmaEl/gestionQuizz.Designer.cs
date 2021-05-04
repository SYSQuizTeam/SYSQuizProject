
namespace TP5_SalmaEl
{
    partial class gestionQuizz
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
            this.gestion_quizz_panel = new System.Windows.Forms.Panel();
            this.continuer_btn = new System.Windows.Forms.Button();
            this.quizz_t = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.question_panel = new System.Windows.Forms.Panel();
            this.supprimer_btn = new System.Windows.Forms.Button();
            this.modifier_qst_btn = new System.Windows.Forms.Button();
            this.modifier_rep_btn = new System.Windows.Forms.Button();
            this.suivant_btn = new System.Windows.Forms.Button();
            this.precedent_btn = new System.Windows.Forms.Button();
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
            this.gestion_quizz_panel.SuspendLayout();
            this.question_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestion_quizz_panel
            // 
            this.gestion_quizz_panel.Controls.Add(this.continuer_btn);
            this.gestion_quizz_panel.Controls.Add(this.quizz_t);
            this.gestion_quizz_panel.Controls.Add(this.label2);
            this.gestion_quizz_panel.Controls.Add(this.label1);
            this.gestion_quizz_panel.Location = new System.Drawing.Point(24, 36);
            this.gestion_quizz_panel.Name = "gestion_quizz_panel";
            this.gestion_quizz_panel.Size = new System.Drawing.Size(734, 170);
            this.gestion_quizz_panel.TabIndex = 1;
            // 
            // continuer_btn
            // 
            this.continuer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuer_btn.Location = new System.Drawing.Point(489, 98);
            this.continuer_btn.Name = "continuer_btn";
            this.continuer_btn.Size = new System.Drawing.Size(160, 34);
            this.continuer_btn.TabIndex = 4;
            this.continuer_btn.Text = "Continuer";
            this.continuer_btn.UseVisualStyleBackColor = true;
            this.continuer_btn.Click += new System.EventHandler(this.continuer_btn_Click);
            // 
            // quizz_t
            // 
            this.quizz_t.FormattingEnabled = true;
            this.quizz_t.Location = new System.Drawing.Point(189, 105);
            this.quizz_t.Name = "quizz_t";
            this.quizz_t.Size = new System.Drawing.Size(151, 24);
            this.quizz_t.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quizz : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Quizz";
            // 
            // question_panel
            // 
            this.question_panel.Controls.Add(this.supprimer_btn);
            this.question_panel.Controls.Add(this.modifier_qst_btn);
            this.question_panel.Controls.Add(this.modifier_rep_btn);
            this.question_panel.Controls.Add(this.suivant_btn);
            this.question_panel.Controls.Add(this.precedent_btn);
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
            this.question_panel.Location = new System.Drawing.Point(43, 2);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(712, 445);
            this.question_panel.TabIndex = 14;
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supprimer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_btn.ForeColor = System.Drawing.Color.Red;
            this.supprimer_btn.Location = new System.Drawing.Point(493, 316);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(198, 31);
            this.supprimer_btn.TabIndex = 19;
            this.supprimer_btn.Text = "Supprimer";
            this.supprimer_btn.UseVisualStyleBackColor = false;
            // 
            // modifier_qst_btn
            // 
            this.modifier_qst_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifier_qst_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_qst_btn.ForeColor = System.Drawing.Color.Green;
            this.modifier_qst_btn.Location = new System.Drawing.Point(493, 197);
            this.modifier_qst_btn.Name = "modifier_qst_btn";
            this.modifier_qst_btn.Size = new System.Drawing.Size(198, 31);
            this.modifier_qst_btn.TabIndex = 18;
            this.modifier_qst_btn.Text = "Modifier question";
            this.modifier_qst_btn.UseVisualStyleBackColor = false;
            // 
            // modifier_rep_btn
            // 
            this.modifier_rep_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modifier_rep_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_rep_btn.ForeColor = System.Drawing.Color.Green;
            this.modifier_rep_btn.Location = new System.Drawing.Point(493, 254);
            this.modifier_rep_btn.Name = "modifier_rep_btn";
            this.modifier_rep_btn.Size = new System.Drawing.Size(198, 31);
            this.modifier_rep_btn.TabIndex = 16;
            this.modifier_rep_btn.Text = "Modifier reponses";
            this.modifier_rep_btn.UseVisualStyleBackColor = false;
            // 
            // suivant_btn
            // 
            this.suivant_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.Location = new System.Drawing.Point(478, 390);
            this.suivant_btn.Name = "suivant_btn";
            this.suivant_btn.Size = new System.Drawing.Size(142, 34);
            this.suivant_btn.TabIndex = 15;
            this.suivant_btn.Text = "Suivant";
            this.suivant_btn.UseVisualStyleBackColor = true;
            // 
            // precedent_btn
            // 
            this.precedent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedent_btn.Location = new System.Drawing.Point(89, 390);
            this.precedent_btn.Name = "precedent_btn";
            this.precedent_btn.Size = new System.Drawing.Size(142, 34);
            this.precedent_btn.TabIndex = 14;
            this.precedent_btn.Text = "Précédent";
            this.precedent_btn.UseVisualStyleBackColor = true;
            // 
            // reponse4_check
            // 
            this.reponse4_check.AutoSize = true;
            this.reponse4_check.Location = new System.Drawing.Point(368, 330);
            this.reponse4_check.Name = "reponse4_check";
            this.reponse4_check.Size = new System.Drawing.Size(18, 17);
            this.reponse4_check.TabIndex = 13;
            this.reponse4_check.UseVisualStyleBackColor = true;
            // 
            // reponse3_check
            // 
            this.reponse3_check.AutoSize = true;
            this.reponse3_check.Location = new System.Drawing.Point(368, 286);
            this.reponse3_check.Name = "reponse3_check";
            this.reponse3_check.Size = new System.Drawing.Size(18, 17);
            this.reponse3_check.TabIndex = 12;
            this.reponse3_check.UseVisualStyleBackColor = true;
            // 
            // reponse2_check
            // 
            this.reponse2_check.AutoSize = true;
            this.reponse2_check.Location = new System.Drawing.Point(368, 243);
            this.reponse2_check.Name = "reponse2_check";
            this.reponse2_check.Size = new System.Drawing.Size(18, 17);
            this.reponse2_check.TabIndex = 11;
            this.reponse2_check.UseVisualStyleBackColor = true;
            // 
            // reponse1_check
            // 
            this.reponse1_check.AutoSize = true;
            this.reponse1_check.Location = new System.Drawing.Point(368, 201);
            this.reponse1_check.Name = "reponse1_check";
            this.reponse1_check.Size = new System.Drawing.Size(18, 17);
            this.reponse1_check.TabIndex = 10;
            this.reponse1_check.UseVisualStyleBackColor = true;
            // 
            // reponse4_t
            // 
            this.reponse4_t.Location = new System.Drawing.Point(71, 326);
            this.reponse4_t.Name = "reponse4_t";
            this.reponse4_t.Size = new System.Drawing.Size(237, 22);
            this.reponse4_t.TabIndex = 9;
            this.reponse4_t.Text = "Réponse 4";
            // 
            // reponse3_t
            // 
            this.reponse3_t.Location = new System.Drawing.Point(71, 282);
            this.reponse3_t.Name = "reponse3_t";
            this.reponse3_t.Size = new System.Drawing.Size(237, 22);
            this.reponse3_t.TabIndex = 8;
            this.reponse3_t.Text = "Réponse 3";
            // 
            // reponse2_t
            // 
            this.reponse2_t.Location = new System.Drawing.Point(71, 239);
            this.reponse2_t.Name = "reponse2_t";
            this.reponse2_t.Size = new System.Drawing.Size(237, 22);
            this.reponse2_t.TabIndex = 7;
            this.reponse2_t.Text = "Réponse 2";
            // 
            // reponse1_t
            // 
            this.reponse1_t.Location = new System.Drawing.Point(71, 197);
            this.reponse1_t.Name = "reponse1_t";
            this.reponse1_t.Size = new System.Drawing.Size(237, 22);
            this.reponse1_t.TabIndex = 6;
            this.reponse1_t.Text = "Réponse 1";
            // 
            // poids_t
            // 
            this.poids_t.Location = new System.Drawing.Point(512, 92);
            this.poids_t.Name = "poids_t";
            this.poids_t.Size = new System.Drawing.Size(68, 22);
            this.poids_t.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "poids";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Réponses : (cochez celle qui est juste)";
            // 
            // question_t
            // 
            this.question_t.Location = new System.Drawing.Point(149, 90);
            this.question_t.Name = "question_t";
            this.question_t.Size = new System.Drawing.Size(237, 22);
            this.question_t.TabIndex = 2;
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.Location = new System.Drawing.Point(31, 90);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(84, 20);
            this.question_label.TabIndex = 1;
            this.question_label.Text = "Question";
            // 
            // quizz_name_label
            // 
            this.quizz_name_label.AutoSize = true;
            this.quizz_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizz_name_label.Location = new System.Drawing.Point(223, 21);
            this.quizz_name_label.Name = "quizz_name_label";
            this.quizz_name_label.Size = new System.Drawing.Size(207, 24);
            this.quizz_name_label.TabIndex = 0;
            this.quizz_name_label.Text = "Questions du quizz : ";
            // 
            // gestionQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.question_panel);
            this.Controls.Add(this.gestion_quizz_panel);
            this.Name = "gestionQuizz";
            this.Text = "gestionQuizz";
            this.gestion_quizz_panel.ResumeLayout(false);
            this.gestion_quizz_panel.PerformLayout();
            this.question_panel.ResumeLayout(false);
            this.question_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gestion_quizz_panel;
        private System.Windows.Forms.Button continuer_btn;
        private System.Windows.Forms.ComboBox quizz_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel question_panel;
        private System.Windows.Forms.Button supprimer_btn;
        private System.Windows.Forms.Button modifier_qst_btn;
        private System.Windows.Forms.Button modifier_rep_btn;
        private System.Windows.Forms.Button suivant_btn;
        private System.Windows.Forms.Button precedent_btn;
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