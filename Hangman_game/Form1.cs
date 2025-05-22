using System;

namespace Hangman_game
{
    public partial class Form1 : Form
    {
        List<string> words = new List<string>
        {
            "farfurie",
            "televizor",
            "monociclu",
            "lasou",
            "fotbal",
            "pensionar",
            "trabant",
            "laminat",
            "parchet",
            "animal"
        };
        int incorrectGuess;
        char[] displayWord;
        string selectedWord;
        Random random;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            incorrectGuess = 0;
            random = new Random();
            selectedWord = words[random.Next(words.Count)];
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            lblWordDisplay.Text = string.Join(" ", displayWord);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbGuess.Text))
                return;

            char guess = tbGuess.Text.ToLower()[0];
            bool correctGuess = false;

            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    displayWord[i] = guess;
                    correctGuess = true;
                }
            }

            lblWordDisplay.Text = string.Join(" ", displayWord);

            if (!correctGuess)
            {
                UpdateHangmanImage();
            }

            if (!lblWordDisplay.Text.Contains("_"))
            {
                MessageBox.Show("Felicitări, ai câștigat!");
                Application.Exit();
            }

            tbGuess.Clear();
            tbGuess.Focus();
        }

        private void UpdateHangmanImage()
        {
            incorrectGuess++;
            switch (incorrectGuess)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    MessageBox.Show("Ai pierdut! Cuvântul era: " + selectedWord);
                    Application.Restart();
                    break;
            }
        }
    }
}