using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MillionaireWinWorfApp
{
    public class Game
    {
        int currentQuestionIndex = -1;
        public Question[] Questions {  get; set; }
        public Player Player { get; set; }

        public WinTable WinTable { get; set; }
        public Game(Player player) 
        {
            Player = player;
            Questions = InitializeQuestions();
            WinTable = new WinTable();

        }

        private Question[] InitializeQuestions()
        {
            var question1 = new Question()
            {
                Text = "Who wrote the play 'Romeo and Juliet'?",
                Answers =
                    [
                        new Answer{ Text = "William Shakespeare", IsCorrect = true },
                        new Answer{ Text = "Leo Tolstoy", IsCorrect = false },
                        new Answer{ Text = "Anton Chekhov", IsCorrect = false },
                        new Answer{ Text = "Alexander Blok", IsCorrect = false },
                    ]

            };
            var question2 = new Question()
            {
                Text = "Which element is represented by the chemical symbol 'O'?",
                Answers =
                    [
                        new Answer{ Text = "Osmium", IsCorrect = false },
                        new Answer{ Text = "Potassium", IsCorrect = false },
                        new Answer{ Text = "Hydrogen", IsCorrect = false },
                        new Answer{ Text = "Oxygen", IsCorrect = true },
                    ]

            };
            var question3 = new Question()
            {
                Text = "What is the name of a straight line that has a beginning but no end?",
                Answers =
                    [
                        new Answer{ Text = "Vector", IsCorrect = false },
                        new Answer{ Text = "Ray", IsCorrect = true },
                        new Answer{ Text = "Segment", IsCorrect = false },
                        new Answer{ Text = "Rod", IsCorrect = false },
                    ]

            };
            var question4 = new Question()
            {
                Text = "How many bones are in the human body?",
                Answers =
                [
                    new Answer{ Text = "458", IsCorrect = false },
                    new Answer{ Text = "307", IsCorrect = false },
                    new Answer{ Text = "308", IsCorrect = false },
                    new Answer{ Text = "206", IsCorrect = true },
                ]
            };

            var question5 = new Question()
            {
                Text = "What language is spoken in Brazil?",
                Answers =
                [
                    new Answer{ Text = "Chinese", IsCorrect = false },
                    new Answer{ Text = "French", IsCorrect = false },
                    new Answer{ Text = "Brazilian", IsCorrect = false },
                    new Answer{ Text = "Portuguese", IsCorrect = true },
                ]
            };

            var question6 = new Question()
            {
                Text = "Which planet is closest to the Sun?",
                Answers =
                [
                    new Answer{ Text = "Titan", IsCorrect = false },
                    new Answer{ Text = "Jupiter", IsCorrect = false },
                    new Answer{ Text = "Mercury", IsCorrect = true },
                    new Answer{ Text = "Venus", IsCorrect = false },
                ]
            };

            var question7 = new Question()
            {
                Text = "What was the first name for ice cream?",
                Answers =
                [
                    new Answer{ Text = "Shake", IsCorrect = false },
                    new Answer{ Text = "Ice Cream", IsCorrect = false },
                    new Answer{ Text = "Gelato", IsCorrect = true },
                    new Answer{ Text = "Iced Dessert", IsCorrect = false },
                ]
            };

            var question8 = new Question()
            {
                Text = "What is the national animal of Scotland?",
                Answers =
                [
                    new Answer{ Text = "Unicorn", IsCorrect = true },
                    new Answer{ Text = "Fish", IsCorrect = false },
                    new Answer{ Text = "Horse", IsCorrect = false },
                    new Answer{ Text = "Hare", IsCorrect = false },
                ]
            };

            var question9 = new Question()
            {
                Text = "What was the last letter added to the English alphabet?",
                Answers =
                [
                    new Answer{ Text = "Z", IsCorrect = false },
                    new Answer{ Text = "J", IsCorrect = true },
                    new Answer{ Text = "Y", IsCorrect = false },
                    new Answer{ Text = "U", IsCorrect = false },
                ]
            };

            var question10 = new Question()
            {
                Text = "How long did the shortest war last?",
                Answers =
                [
                    new Answer{ Text = "5 minutes", IsCorrect = false },
                    new Answer{ Text = "38 minutes", IsCorrect = true },
                    new Answer{ Text = "2 days", IsCorrect = false },
                    new Answer{ Text = "20 minutes", IsCorrect = false },
                ]
            };

            var question11 = new Question()
            {
                Text = "Which Russian writer wrote the famous 'Anna Karenina'?",
                Answers =
                [
                    new Answer{ Text = "Anton Chekhov", IsCorrect = false },
                    new Answer{ Text = "Nikolai Gogol", IsCorrect = false },
                    new Answer{ Text = "Leo Tolstoy", IsCorrect = true },
                    new Answer{ Text = "Fyodor Dostoevsky", IsCorrect = false },
                ]
            };

            var question12 = new Question()
            {
                Text = "What is the dot above the letters i and j called?",
                Answers =
                [
                    new Answer{ Text = "Tilde", IsCorrect = false },
                    new Answer{ Text = "Delta", IsCorrect = false },
                    new Answer{ Text = "Tittle", IsCorrect = true },
                    new Answer{ Text = "Alpha", IsCorrect = false },
                ]
            };

            var question13 = new Question()
            {
                Text = "How many elements are in the periodic table?",
                Answers =
                    [
                        new Answer{ Text = "118", IsCorrect = true },
                        new Answer{ Text = "214", IsCorrect = false },
                        new Answer{ Text = "145", IsCorrect = false },
                        new Answer{ Text = "148", IsCorrect = false },
                    ]
            };

            var question14 = new Question()
            {
                Text = "What were the U.S. spacecraft designed to go to the Moon called?",
                Answers =
                [
                    new Answer{ Text = "Atlas", IsCorrect = false },
                    new Answer{ Text = "Apollo", IsCorrect = true },
                    new Answer{ Text = "Deuterium", IsCorrect = false },
                    new Answer{ Text = "Skynet", IsCorrect = false },
                ]
            };

            var question15 = new Question()
            {
                Text = "What is the galaxy that includes Earth called?",
                Answers =
                [
                    new Answer{ Text = "Milky Way", IsCorrect = true },
                    new Answer{ Text = "World", IsCorrect = false },
                    new Answer{ Text = "Earth", IsCorrect = false },
                    new Answer{ Text = "Andromeda Galaxy", IsCorrect = false },
                ]
            };

            return [question1, question2, question3,
                    question4, question5, question6,
                    question7, question8, question9,
                    question10, question11, question12,
                    question13, question14, question15];

           
        }

        public Question GetNextQuestion()
        {
            currentQuestionIndex++;
            return Questions[currentQuestionIndex];
        }

        public  bool CheckAnswer(string answerText)
        {
            var currentQuestion = Questions[currentQuestionIndex];
            var selectedAnswer = currentQuestion.Answers.First(x => x.Text == answerText);

            if(selectedAnswer.IsCorrect)
            {
                WinTable.Next();
   
            }
            else
            {
                WinTable.Lose();
            }
            return selectedAnswer.IsCorrect;
        }
        public bool IsWin()
        {
            return WinTable.GetCurrent().Count == 1000000;
        }

        public  Question FiftyFifty()
        {
            var currentQuestion = Questions[currentQuestionIndex];
            var inCorrectAnswers = currentQuestion.Answers.Where(x => !x.IsCorrect).ToArray();
            var ramdom = new Random();
            var randomInCorrectAnswerIndex = ramdom.Next(0, inCorrectAnswers.Length);
            for(int i = 0; i < inCorrectAnswers.Length; i++)
            {
                if(i != randomInCorrectAnswerIndex)
                {
                    inCorrectAnswers[i].Text = string.Empty;
                }
            }

            return currentQuestion;
        }
    }
    
}
