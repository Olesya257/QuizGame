using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 5) / totalQuestions);
                MessageBox.Show(
                    "Первый урок окончен" + Environment.NewLine +
                    "Вы ответили на" + score + " вопросов правильно." + Environment.NewLine +
                    "Ваш оценка равна " + percentage + "" + Environment.NewLine +
                    "Нажмите Ok, чтобы продолжить игру"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.question;
                    labelQuestions.Text = "Выбрать правильный перевод слова Ийэ";
                    button1.Text = "Отец";
                    button2.Text = "Мать";
                    button3.Text = "Сестра";
                    button4.Text = "Брат";
                    correctAnswer = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.animal;
                    labelQuestions.Text = "Выбрать правильный перевод слова Аҕа";
                    button1.Text = "Отец";
                    button2.Text = "Мать";
                    button3.Text = "Сестра";
                    button4.Text = "Брат";
                    correctAnswer = 1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.words;
                    labelQuestions.Text = "Выбрать правильный перевод слова Эдьиий или Балтым";
                    button1.Text = "Отец";
                    button2.Text = "Мать";
                    button3.Text = "Сестра";
                    button4.Text = "Брат";
                    correctAnswer = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.question;
                    labelQuestions.Text = "Выбрать правильный перевод слова Быраат или Убай";
                    button1.Text = "Отец";
                    button2.Text = "Мать";
                    button3.Text = "Сестра";
                    button4.Text = "Брат";
                    correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.animal;
                    labelQuestions.Text = "Выбрать правильный перевод слова Биир";
                    button1.Text = "Один";
                    button2.Text = "Два";
                    button3.Text = "Три";
                    button4.Text = "Ноль";
                    correctAnswer = 1;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.words;
                    labelQuestions.Text = "Выбрать правильный перевод слова Икки";
                    button1.Text = "Один";
                    button2.Text = "Два";
                    button3.Text = "Три";
                    button4.Text = "Ноль";
                    correctAnswer = 2;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.question;
                    labelQuestions.Text = "Выбрать правильный перевод слова Үс";
                    button1.Text = "Один";
                    button2.Text = "Два";
                    button3.Text = "Три";
                    button4.Text = "Ноль";
                    correctAnswer = 3;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.animal;
                    labelQuestions.Text = "Выбрать правильный перевод слова Мурун";
                    button1.Text = "Нос";
                    button2.Text = "Губы";
                    button3.Text = "Глаза";
                    button4.Text = "Брови";
                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.words;
                    labelQuestions.Text = "Выбрать правильный перевод слова Харах";
                    button1.Text = "Очки";
                    button2.Text = "Глаза";
                    button3.Text = "Брови";
                    button4.Text = "Веко";
                    correctAnswer = 2;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.question;
                    labelQuestions.Text = "Выбрать правильный перевод слова Уос";
                    button1.Text = "Борода";
                    button2.Text = "Щеки";
                    button3.Text = "Скулы";
                    button4.Text = "Губы";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
