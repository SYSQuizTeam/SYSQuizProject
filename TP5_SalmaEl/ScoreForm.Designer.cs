
namespace TP5_SalmaEl
{
    partial class ScoreForm
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
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(345, 206);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(100, 20);
            this.ScoreBox.TabIndex = 0;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreBox);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScoreBox;
    }
}