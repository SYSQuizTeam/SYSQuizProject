
namespace TP5_SalmaEl
{
    partial class QuizzMenu
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
            this.QuizzList = new System.Windows.Forms.ComboBox();
            this.QuizMenuBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizzList
            // 
            this.QuizzList.Location = new System.Drawing.Point(260, 192);
            this.QuizzList.Name = "QuizzList";
            this.QuizzList.Size = new System.Drawing.Size(237, 21);
            this.QuizzList.TabIndex = 3;
            // 
            // QuizMenuBTN
            // 
            this.QuizMenuBTN.Location = new System.Drawing.Point(337, 255);
            this.QuizMenuBTN.Name = "QuizMenuBTN";
            this.QuizMenuBTN.Size = new System.Drawing.Size(94, 33);
            this.QuizMenuBTN.TabIndex = 1;
            this.QuizMenuBTN.Text = "Continuer";
            this.QuizMenuBTN.UseVisualStyleBackColor = true;
            this.QuizMenuBTN.Click += new System.EventHandler(this.QuizMenuBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez selectionnez un quiz";
            // 
            // QuizzMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuizMenuBTN);
            this.Controls.Add(this.QuizzList);
            this.Name = "QuizzMenu";
            this.Text = "QuizzMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox QuizzList;
        private System.Windows.Forms.Button QuizMenuBTN;
        private System.Windows.Forms.Label label1;
    }
}