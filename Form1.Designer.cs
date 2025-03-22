namespace Bible_Study_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnOldTestament = new Button();
            btnNewTestament = new Button();
            btnParables = new Button();
            btnCharacters = new Button();
            btnProphets = new Button();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(100, 52);
            label1.Name = "label1";
            label1.Size = new Size(614, 54);
            label1.TabIndex = 0;
            label1.Text = "Select a Bible Quiz Topic";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOldTestament
            // 
            btnOldTestament.BackColor = Color.Tan;
            btnOldTestament.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOldTestament.Location = new Point(259, 159);
            btnOldTestament.Name = "btnOldTestament";
            btnOldTestament.Size = new Size(214, 34);
            btnOldTestament.TabIndex = 1;
            btnOldTestament.Text = "Old Testament";
            btnOldTestament.UseVisualStyleBackColor = false;
            btnOldTestament.Click += btnOldTestament_Click;
            // 
            // btnNewTestament
            // 
            btnNewTestament.BackColor = Color.Tan;
            btnNewTestament.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewTestament.Location = new Point(259, 211);
            btnNewTestament.Name = "btnNewTestament";
            btnNewTestament.Size = new Size(214, 34);
            btnNewTestament.TabIndex = 2;
            btnNewTestament.Text = "New Testament";
            btnNewTestament.UseVisualStyleBackColor = false;
            btnNewTestament.Click += btnNewTestament_Click;
            // 
            // btnParables
            // 
            btnParables.BackColor = Color.Tan;
            btnParables.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParables.Location = new Point(259, 263);
            btnParables.Name = "btnParables";
            btnParables.Size = new Size(225, 34);
            btnParables.TabIndex = 3;
            btnParables.Text = "Parables of Jesus";
            btnParables.UseVisualStyleBackColor = false;
            btnParables.Click += btnParables_Click;
            // 
            // btnCharacters
            // 
            btnCharacters.BackColor = Color.Tan;
            btnCharacters.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCharacters.Location = new Point(259, 369);
            btnCharacters.Name = "btnCharacters";
            btnCharacters.Size = new Size(134, 34);
            btnCharacters.TabIndex = 4;
            btnCharacters.Text = "Prophets";
            btnCharacters.UseVisualStyleBackColor = false;
            btnCharacters.Click += btnCharacters_Click;
            // 
            // btnProphets
            // 
            btnProphets.BackColor = Color.Tan;
            btnProphets.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProphets.Location = new Point(259, 318);
            btnProphets.Name = "btnProphets";
            btnProphets.Size = new Size(241, 34);
            btnProphets.TabIndex = 5;
            btnProphets.Text = "Bible Characters";
            btnProphets.UseVisualStyleBackColor = false;
            btnProphets.Click += btnProphets_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnProphets);
            Controls.Add(btnCharacters);
            Controls.Add(btnParables);
            Controls.Add(btnNewTestament);
            Controls.Add(btnOldTestament);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOldTestament;
        private Button btnNewTestament;
        private Button btnParables;
        private Button btnCharacters;
        private Button btnProphets;
    }
}
