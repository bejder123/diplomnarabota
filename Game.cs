using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stanibogat
{
    public partial class Game : Form
    {
        private int score;
        private int questionnumb = 0;
        private string answer;
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            loadNextQuestion();
        }
        private void loadNextQuestion() {
            questionnumb ++;
            switch(questionnumb) 
            {
                case 1: questionLabel.Text = "What is the capital of Spain?";
                    btnA.Text= "Madrid";
                    BtnB.Text = "Barcelona";
                    BtnC.Text = "Seville";
                    BtnD.Text = "Valencia";
                    answer = "Madrid";
                    break;

                case 2:
                    questionLabel.Text = "What is the smallest country in the world by land area?";
                    btnA.Text = "Monaco";
                    BtnB.Text = "Vatican City";
                    BtnC.Text = "San Marino";
                    BtnD.Text = "Liechtenstein";
                    answer = "Vatican City";
                    break;

                case 3:
                    questionLabel.Text = "Which element has the highest melting point?";
                    btnA.Text = "Tungsten";
                    BtnB.Text = "Carbon";
                    BtnC.Text = "Platinum";
                    BtnD.Text = "Titanium";
                    answer = "Tungsten";
                    break;

                case 4:
                    questionLabel.Text = "In what year was the first photograph taken?";
                    btnA.Text = "1826";
                    BtnB.Text = "1839";
                    BtnC.Text = "1848";
                    BtnD.Text = "1853";
                    answer = "1826";
                    break;

                case 5:
                    questionLabel.Text = "Who is the only U.S. President to have received a patent for an invention?";
                    btnA.Text = "Abraham Lincoln";
                    BtnB.Text = "Thomas Jefferson";
                    BtnC.Text = "George Washington";
                    BtnD.Text = "James Madison";
                    answer = "Thomas Jefferson";
                    break;

                case 6:
                    questionLabel.Text = "What is the name of the phenomenon that causes the smell of rain?";
                    btnA.Text = "Ozonolysis";
                    BtnB.Text = "Methanogenesis";
                    BtnC.Text = "Hydrolysis";
                    BtnD.Text = "Petrichor";
                    answer = "Petrichor";
                    break;

                case 7:
                    questionLabel.Text = "What is the name of the rarest naturally occurring element on Earth by weight?";
                    btnA.Text = "Astatine";
                    BtnB.Text = "Francium";
                    BtnC.Text = "Promethium";
                    BtnD.Text = "Radium";
                    answer = "Francium";
                    break;

                default:questionLabel.Text = "You win" + score;
                    break;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string choice = btnA.Text;
            if (choice == answer)
            {
                btnA.BackColor = Color.Green;

            }
        }
    }
}
