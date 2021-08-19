/**
 * Victor You
 * this is a multiple choice test that questions one's knowledge of Starcraft II
 * a  special feature to be aware of the addition of sound to one of the buttons (labeled "PLAY")
 * other than that, anything else should come through completion of the quiz
 * the most interesting thing in the learning for this assignment is the addition of the sound to this form
 * something that i ran into trouble with was attempting to pause music and then resume it from the point at wich it had been paused. This did not make it into the final version
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceQuiz
{
    public partial class background : Form
    {
        //creates new sound player
        System.Media.SoundPlayer voicePlayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer submitPlayer = new System.Media.SoundPlayer();
        //variables to check if all the questions had been answered and whether they had been done correctly. also has a variable to store the score of the player
        bool answeredCorrectly1 = false;
        bool answeredCorrectly2 = false;
        bool answeredCorrectly3 = false;
        bool answeredCorrectly4 = false;
        bool answerBlank1 = true;
        bool answerBlank2 = true;
        bool answerBlank3 = true;
        bool answerBlank4 = true;
        int answersCorrect;

        public background()
        {
            InitializeComponent();
            //specifies file to play
            voicePlayer.SoundLocation = "findlay.wav";
            submitPlayer.SoundLocation = "SCVReady.wav";
            //during idle, checks the answers in the text boxes and sees if they are correct
            Application.Idle += checkAnswers;

        }
        
        //checks if the answers are correct. Also checks if any answeres were left blank
        private void checkAnswers(object sender, EventArgs e)
        {
            if (answerBox1.Text == "C")
            {
                answeredCorrectly1 = true;
                answerBlank1 = false;
            }
            else if (answerBox1.Text == "")
            {
                answerBlank1 = true;
            }
            else
            {
                answeredCorrectly1 = false;
                answerBlank1 = false;
            }
            if(answerBox2.Text == "A")
            {
                answeredCorrectly2 = true;
                answerBlank2 = false;
            }
            else if (answerBox2.Text == "")
            {
                answerBlank2 = true;
            }
            else
            {
                answeredCorrectly2 = false;
                answerBlank2 = false;
            }
            if(answerBox3.Text == "A")
            {
                answeredCorrectly3 = true;
                answerBlank3 = false;
            }
            else if (answerBox3.Text == "")
            {
                answerBlank3 = true;
            }
            else
            {
                answeredCorrectly3 = false;
                answerBlank3 = false;
            }
     
            if (answerBox4.Text == "D")
            {
                answeredCorrectly4 = true;
                answerBlank4 = false;
            }
            else if (answerBox4.Text == "")
            {
                answerBlank4 = true;
            }
            else
            {
                answeredCorrectly4 = false;
                answerBlank4 = false;
            }
        }
        //sets the corresponding text box to the answer clicked
        private void buttonQ1AA_Click(object sender, EventArgs e)
        {
            
            answerBox1.Text = "A";
        }

        private void buttonQ1AB_Click(object sender, EventArgs e)
        {
            answerBox1.Text = "B";
        }

        private void buttonQ1AC_Click(object sender, EventArgs e)
        {
            answerBox1.Text = "C";
        }

        private void buttonQ1AD_Click(object sender, EventArgs e)
        {
            answerBox1.Text = "D";
        }

        private void buttonQ2AA_Click(object sender, EventArgs e)
        {
            answerBox2.Text = "A";
        }

        private void buttonQ2AB_Click(object sender, EventArgs e)
        {
            answerBox2.Text = "B";
        }

        private void buttonQ2AC_Click(object sender, EventArgs e)
        {
            answerBox2.Text = "C";
        }

        private void buttonQ2AD_Click(object sender, EventArgs e)
        {
            answerBox2.Text = "D";
        }
        private void buttonQ3AA_Click(object sender, EventArgs e)
        {
            answerBox3.Text = "A";
        }

        private void buttonQ3AB_Click(object sender, EventArgs e)
        {
            answerBox3.Text = "B";
        }

        private void buttonQ3AC_Click(object sender, EventArgs e)
        {
            answerBox3.Text = "C"; 
        }

        private void buttonQ3AD_Click(object sender, EventArgs e)
        {
            answerBox3.Text = "D";
        }
        private void buttonQ4AA_Click(object sender, EventArgs e)
        {
            answerBox4.Text = "A";
        }

        private void buttonQ4AB_Click(object sender, EventArgs e)
        {
            answerBox4.Text = "B";
        }

        private void buttonQ4AC_Click(object sender, EventArgs e)
        {
            answerBox4.Text = "C";
        }

        private void buttonQ4AD_Click(object sender, EventArgs e)
        {
            answerBox4.Text = "D";
        }
        //plays the voice clip when the button is pressed
        private void buttonPlayVoice_Click(object sender, EventArgs e)
        {
            voicePlayer.Play();
        }
        //tells the user whether they have answered all the questions and sees whether they get it correct
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            //resets amount of correct answers to 0 and recounts the number of correct answers
            answersCorrect = 0;
            if (answeredCorrectly1)
            {
                answersCorrect++;
            }
            if (answeredCorrectly2)
            {
                answersCorrect++;
            }
            if (answeredCorrectly3)
            {
                answersCorrect++;
            }
            if (answeredCorrectly4)
            {
                answersCorrect++;
            }
            //outputs the users score or tells them whether they left any blank
            if (!answerBlank1 && !answerBlank2 && !answerBlank3 && !answerBlank4)
            {
                MessageBox.Show("You got " + answersCorrect.ToString() + " out of 4 correct");
            }
            else if (answerBlank1 || answerBlank2 || answerBlank3 || answerBlank4)
            {
                MessageBox.Show("You got " + answersCorrect.ToString() + " out of 4 correct but some answers have been left blank");
            }
        }
        //resets the text and all the variables
        private void buttonClear_Click(object sender, EventArgs e)
        {
            submitPlayer.Play();
            answerBox1.Text = "";
            answerBox2.Text = "";
            answerBox3.Text = "";
            answerBox4.Text = "";
            answeredCorrectly1 = false;
            answeredCorrectly2 = false;
            answeredCorrectly3 = false;
            answeredCorrectly4 = false;
            answerBlank1 = true;
            answerBlank2 = true;
            answerBlank3 = true;
            answerBlank4 = true;
            answersCorrect = 0;
        }
    }
}
