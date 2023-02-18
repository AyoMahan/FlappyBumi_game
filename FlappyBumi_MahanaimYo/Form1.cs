using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBumi_MahanaimYo
{
    public partial class Form1 : Form
    {
        int pipeSpeed=8;
        int gravity=10;
        int score=0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bumi.Top += gravity; //pushes icon down as soon as the timer starts
            pipeBottom.Left -= pipeSpeed;//calling pipes to the other end
            pipeTop.Left -= pipeSpeed;
            ScoreBox.Text = "SCORE: " + score.ToString();
            


            if (pipeBottom.Left < -50) 
            {
                pipeBottom.Left = 600;
                score++;
             }
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 700;
                score++;
            }

            if(bumi.Bounds.IntersectsWith(pipeBottom.Bounds)||
                bumi.Bounds.IntersectsWith(pipeTop.Bounds)||
                bumi.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreBox.Text += "                  GAME OVER GG NT";
        }

        private void gamekeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
    }
}
