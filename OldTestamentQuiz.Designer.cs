namespace Bible_Study_App
{
    partial class OldTestamentQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldTestamentQuiz));
            lblQuestion = new Label();
            lblFeedback = new Label();
            rbtnOption1 = new RadioButton();
            rbtnOption2 = new RadioButton();
            rbtnOption3 = new RadioButton();
            rbtnOption4 = new RadioButton();
            btnNext = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(162, 49);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(83, 26);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(643, 380);
            lblFeedback.Margin = new Padding(4, 0, 4, 0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 26);
            lblFeedback.TabIndex = 1;
            // 
            // rbtnOption1
            // 
            rbtnOption1.AutoSize = true;
            rbtnOption1.Location = new Point(304, 115);
            rbtnOption1.Margin = new Padding(4, 3, 4, 3);
            rbtnOption1.Name = "rbtnOption1";
            rbtnOption1.Size = new Size(191, 30);
            rbtnOption1.TabIndex = 2;
            rbtnOption1.TabStop = true;
            rbtnOption1.Text = "radioButton1";
            rbtnOption1.UseVisualStyleBackColor = true;
            // 
            // rbtnOption2
            // 
            rbtnOption2.AutoSize = true;
            rbtnOption2.Location = new Point(304, 172);
            rbtnOption2.Margin = new Padding(4, 3, 4, 3);
            rbtnOption2.Name = "rbtnOption2";
            rbtnOption2.Size = new Size(191, 30);
            rbtnOption2.TabIndex = 3;
            rbtnOption2.TabStop = true;
            rbtnOption2.Text = "radioButton2";
            rbtnOption2.UseVisualStyleBackColor = true;
            // 
            // rbtnOption3
            // 
            rbtnOption3.AutoSize = true;
            rbtnOption3.Location = new Point(304, 233);
            rbtnOption3.Margin = new Padding(4, 3, 4, 3);
            rbtnOption3.Name = "rbtnOption3";
            rbtnOption3.Size = new Size(191, 30);
            rbtnOption3.TabIndex = 4;
            rbtnOption3.TabStop = true;
            rbtnOption3.Text = "radioButton3";
            rbtnOption3.UseVisualStyleBackColor = true;
            // 
            // rbtnOption4
            // 
            rbtnOption4.AutoSize = true;
            rbtnOption4.Location = new Point(304, 286);
            rbtnOption4.Margin = new Padding(4, 3, 4, 3);
            rbtnOption4.Name = "rbtnOption4";
            rbtnOption4.Size = new Size(191, 30);
            rbtnOption4.TabIndex = 5;
            rbtnOption4.TabStop = true;
            rbtnOption4.Text = "radioButton4";
            rbtnOption4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkCyan;
            btnNext.Enabled = false;
            btnNext.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Location = new Point(950, 253);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(157, 119);
            btnNext.TabIndex = 7;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Red;
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(455, 343);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(157, 63);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // OldTestamentQuiz
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1120, 468);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(rbtnOption4);
            Controls.Add(rbtnOption3);
            Controls.Add(rbtnOption2);
            Controls.Add(rbtnOption1);
            Controls.Add(lblFeedback);
            Controls.Add(lblQuestion);
            Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "OldTestamentQuiz";
            Text = "Form2";
            TransparencyKey = Color.IndianRed;
            Load += OldTestamentQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Label lblFeedback;
        private RadioButton rbtnOption1;
        private RadioButton rbtnOption2;
        private RadioButton rbtnOption3;
        private RadioButton rbtnOption4;
        private Button btnNext;
        private Button btnSubmit;
    }
}