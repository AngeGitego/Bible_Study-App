using static System.Formats.Asn1.AsnWriter;

namespace Bible_Study_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Starting Soon!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Starting Soon!");

        }

        private void btnOldTestament_Click(object sender, EventArgs e)
        {
            OldTestamentQuiz quizForm = new OldTestamentQuiz(); // Create instance of the quiz form
            quizForm.Show(); // Show the quiz form
            this.Hide(); // Hide the main menu
        }


        private void btnProphets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Starting Soon!");

        }

        private void btnCharacters_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Starting Soon!");

        }

        private void btnNewTestament_Click(object sender, EventArgs e)
        {

        }

        private void btnParables_Click(object sender, EventArgs e)
        {

        }
        

    }
}
