
namespace TP5_SalmaEl
{
    partial class QuestionForm
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
            this.designiationQuiz = new System.Windows.Forms.Label();
            this.QuestionQuiz = new System.Windows.Forms.Label();
            this.reponse1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reponse2 = new System.Windows.Forms.Label();
            this.reponse3 = new System.Windows.Forms.Label();
            this.reponse4 = new System.Windows.Forms.Label();
            this.NextQuestionBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // designiationQuiz
            // 
            this.designiationQuiz.AutoSize = true;
            this.designiationQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designiationQuiz.Location = new System.Drawing.Point(67, 57);
            this.designiationQuiz.Name = "designiationQuiz";
            this.designiationQuiz.Size = new System.Drawing.Size(57, 20);
            this.designiationQuiz.TabIndex = 1;
            this.designiationQuiz.Text = "label1";
            // 
            // QuestionQuiz
            // 
            this.QuestionQuiz.AutoSize = true;
            this.QuestionQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionQuiz.Location = new System.Drawing.Point(343, 112);
            this.QuestionQuiz.Name = "QuestionQuiz";
            this.QuestionQuiz.Size = new System.Drawing.Size(57, 20);
            this.QuestionQuiz.TabIndex = 2;
            this.QuestionQuiz.Text = "label2";
            // 
            // reponse1
            // 
            this.reponse1.AutoSize = true;
            this.reponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse1.Location = new System.Drawing.Point(350, 169);
            this.reponse1.Name = "reponse1";
            this.reponse1.Size = new System.Drawing.Size(35, 20);
            this.reponse1.TabIndex = 3;
            this.reponse1.Text = "rep";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // reponse2
            // 
            this.reponse2.AutoSize = true;
            this.reponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse2.Location = new System.Drawing.Point(350, 211);
            this.reponse2.Name = "reponse2";
            this.reponse2.Size = new System.Drawing.Size(35, 20);
            this.reponse2.TabIndex = 4;
            this.reponse2.Text = "rep";
            // 
            // reponse3
            // 
            this.reponse3.AutoSize = true;
            this.reponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse3.Location = new System.Drawing.Point(350, 243);
            this.reponse3.Name = "reponse3";
            this.reponse3.Size = new System.Drawing.Size(35, 20);
            this.reponse3.TabIndex = 5;
            this.reponse3.Text = "rep";
            // 
            // reponse4
            // 
            this.reponse4.AutoSize = true;
            this.reponse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse4.Location = new System.Drawing.Point(350, 273);
            this.reponse4.Name = "reponse4";
            this.reponse4.Size = new System.Drawing.Size(35, 20);
            this.reponse4.TabIndex = 6;
            this.reponse4.Text = "rep";
            // 
            // NextQuestionBTN
            // 
            this.NextQuestionBTN.Location = new System.Drawing.Point(316, 336);
            this.NextQuestionBTN.Name = "NextQuestionBTN";
            this.NextQuestionBTN.Size = new System.Drawing.Size(94, 33);
            this.NextQuestionBTN.TabIndex = 7;
            this.NextQuestionBTN.Text = "Suivant";
            this.NextQuestionBTN.UseVisualStyleBackColor = true;
            this.NextQuestionBTN.Click += new System.EventHandler(this.NextQuestionBTN_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextQuestionBTN);
            this.Controls.Add(this.reponse4);
            this.Controls.Add(this.reponse3);
            this.Controls.Add(this.reponse2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reponse1);
            this.Controls.Add(this.QuestionQuiz);
            this.Controls.Add(this.designiationQuiz);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designiationQuiz;
        private System.Windows.Forms.Label QuestionQuiz;
        private System.Windows.Forms.Label reponse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reponse2;
        private System.Windows.Forms.Label reponse3;
        private System.Windows.Forms.Label reponse4;
        private System.Windows.Forms.Button NextQuestionBTN;
    }
}