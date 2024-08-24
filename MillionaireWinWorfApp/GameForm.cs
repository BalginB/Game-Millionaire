namespace MillionaireWinWorfApp
{
    public partial class GameForm : Form
    {

        Game game;

        RadioButton[] radioButtonsTable;

        public GameForm()
        {
            InitializeComponent();
            radioButtonsTable =
                [
                radioButton1, radioButton2, radioButton3,
                radioButton4, radioButton5, radioButton6,
                radioButton7, radioButton8, radioButton9,
                radioButton10, radioButton11, radioButton12,
                radioButton13, radioButton14, radioButton15,

                ];
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            game = new Game(new Player { Name = "Batyr" });
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            var nextQuestion = game.GetNextQuestion();

            questionTextLabel.Text = nextQuestion.Text;


            answerTextButton1.Text = nextQuestion.Answers[0].Text;
            answerTextButton2.Text = nextQuestion.Answers[1].Text;
            answerTextButton3.Text = nextQuestion.Answers[2].Text;
            answerTextButton4.Text = nextQuestion.Answers[3].Text;
        }

        private void answerTextButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            var isCorrect = game.CheckAnswer(clickedButton.Text);

            UpdateRadioButtonsTable();

            if (isCorrect)
            {
                clickedButton.BackColor = Color.Green;
                if (game.IsWin())
                {
                    MessageBox.Show("Congratilations! You won a one million dollars!");
                    return;
                }
                MessageBox.Show($"Yes, you are right! You have already {game.WinTable.GetCurrent().Count} dollars");
                clickedButton.BackColor = Color.CornflowerBlue;
                ShowNextQuestion();
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                DisabledAnswersButton();

                MessageBox.Show("Game over");
            }
        }

        private void DisabledAnswersButton()
        {
            answerTextButton1.Enabled = false;
            answerTextButton2.Enabled = false;
            answerTextButton3.Enabled = false;
            answerTextButton4.Enabled = false;
        }

        private void UpdateRadioButtonsTable()
        {
            foreach (var currentRadioButton in radioButtonsTable)
            {
                var currentWinTableRow = game.WinTable.Wins.First(x => x.Count.ToString() == currentRadioButton.Text);

                if (game.WinTable.GetCurrent() != null && currentRadioButton.Text == game.WinTable.GetCurrent().Count.ToString())
                {
                    currentRadioButton.Checked = true;
                    currentRadioButton.Enabled = true;
                    currentRadioButton.BackColor = Color.Yellow;
                }
                else
                {
                    currentRadioButton.Checked = false;
                    currentRadioButton.Enabled = false;
                    currentRadioButton.BackColor = currentWinTableRow.IsMilestone ? Color.Aqua : SystemColors.ActiveCaption;
                }
            }
        }



        private void FiftiFiftyButton_Click(object sender, EventArgs e)
        {
            FiftiFiftyButton.Enabled = false;
            FiftiFiftyButton.BackColor = Color.Gray;
            var question = game.FiftyFifty();
            answerTextButton1.Text = question.Answers[0].Text;
            answerTextButton2.Text = question.Answers[1].Text;
            answerTextButton3.Text = question.Answers[2].Text;
            answerTextButton4.Text = question.Answers[3].Text;
        }

    }
}
