using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;  // Required for playing sounds
using System.Windows.Forms;

namespace Bible_Study_App
{
    public partial class OldTestamentQuiz : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private int timeLeft = 10; // Time per question in seconds
        private SoundPlayer timeoutSound; // Sound effect for timeout

        public OldTestamentQuiz()
        {
            InitializeComponent();
            LoadQuestions();
            InitializeTimer();  // Initialize the timer
            DisplayQuestion();
        }

        private void InitializeTimer()
        {
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000; // 1 second interval
            Timer.Tick += Timer_Tick;

            // Load the default Windows error sound for timeout
            timeoutSound = new SoundPlayer(); // Initialize SoundPlayer (optional)

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"Time Left: {timeLeft}s";

            if (timeLeft <= 0)
            {
                Timer.Stop();
                SystemSounds.Exclamation.Play(); // Play system sound when time runs out

                MessageBox.Show("Time's up! Moving to the next question.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblFeedback.Text = $"Time's up! The correct answer is: {questions[currentQuestionIndex].Options[questions[currentQuestionIndex].CorrectAnswerIndex]}";
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Visible = true;

                btnSubmit.Enabled = false;
                btnNext.Enabled = true;
            }
        }
        private void LoadQuestions()
        {
            questions = new List<Question>
        {
            new Question("Who led the Israelites out of Egypt?", new[] { "Moses", "Abraham", "Noah", "David" }, 0),
            new Question("What is the first book of the Old Testament?", new[] { "Exodus", "Genesis", "Leviticus", "Numbers" }, 1),
            new Question("Who was swallowed by a great fish?", new[] { "Elijah", "Jonah", "Daniel", "Isaiah" }, 1),
            new Question("Who built the ark?", new[] { "Moses", "Noah", "Elijah", "Solomon" }, 1),
            new Question("Which king built the first temple in Jerusalem?", new[] { "David", "Solomon", "Saul", "Hezekiah" }, 1),
            new Question("Who received the Ten Commandments?", new[] { "Moses", "Joshua", "Aaron", "Isaiah" }, 0)
        };
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.Text;
                rbtnOption1.Text = question.Options[0];
                rbtnOption2.Text = question.Options[1];
                rbtnOption3.Text = question.Options[2];
                rbtnOption4.Text = question.Options[3];

                // Reset selections
                rbtnOption1.Checked = false;
                rbtnOption2.Checked = false;
                rbtnOption3.Checked = false;
                rbtnOption4.Checked = false;

                // Reset UI
                lblFeedback.Text = "";
                lblFeedback.Visible = false;

                // Reset Timer
                timeLeft = 10;
                lblTimer.Text = $"Time Left: {timeLeft}s";
                Timer.Start();

                // Enable Submit, Disable Next
                btnSubmit.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                ShowResults();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= questions.Count) return;

            Timer.Stop(); // Stop the timer when the user submits an answer

            var question = questions[currentQuestionIndex];

            int selectedAnswer = -1;
            if (rbtnOption1.Checked) selectedAnswer = 0;
            else if (rbtnOption2.Checked) selectedAnswer = 1;
            else if (rbtnOption3.Checked) selectedAnswer = 2;
            else if (rbtnOption4.Checked) selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("Please select an answer before submitting.");
                return;
            }

            if (selectedAnswer == question.CorrectAnswerIndex)
            {
                lblFeedback.Text = "Correct!";
                lblFeedback.ForeColor = Color.Green;
                score++;
            }
            else
            {
                lblFeedback.Text = $"Incorrect! The correct answer is: {question.Options[question.CorrectAnswerIndex]}";
                lblFeedback.ForeColor = Color.Red;
            }

            lblFeedback.Visible = true;

            // Disable Submit & Enable Next
            btnSubmit.Enabled = false;
            btnNext.Enabled = true;

            // Update the progress bar
            UpdateProgressBar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                ShowResults();
            }

            // Update the progress bar
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            // Set the progress value based on the current question index
            progressBar.Value = (int)((float)currentQuestionIndex / questions.Count * 100);
        }


        private void ShowResults()
        {
            Timer.Stop(); // Stop the timer at the end
            DialogResult result = MessageBox.Show(
                $"Quiz Completed!\nScore: {score}/{questions.Count} ({(score * 100) / questions.Count}%)\n\nWould you like to retake the quiz?",
                "Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                RetakeQuiz();
            }
            else
            {
                this.Close();
            }
        }

        private void RetakeQuiz()
        {
            score = 0;
            currentQuestionIndex = 0;
            lblFeedback.Text = "";
            lblFeedback.Visible = false;

            // Enable Submit, Disable Next
            btnSubmit.Enabled = true;
            btnNext.Enabled = false;

            DisplayQuestion();
        }

        private void OldTestamentQuiz_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;  // Ensure Submit is enabled at start
            btnNext.Enabled = false;   // Next should be disabled initially
        }

        private void UpdateProgressBar(object sender, EventArgs e)
        {
            // Set the progress value based on the current question index
            progressBar.Value = (int)((float)currentQuestionIndex / questions.Count * 100);
        }
    }
}
