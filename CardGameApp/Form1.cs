using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameApp
{
    public partial class Form1 : Form
    {
        //Declare global variables
        //Declare the toptenscorescreen variable
        public static TopTenScoreScreen scorescreen = new TopTenScoreScreen();
        public static GameScene game = new GameScene();


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInstruction_Click(object sender, EventArgs e)
        {
            //Write code to respond to the "click event"
            //pop up a message to display the game instructions
            string title = "Game Rules";
            string message = "Game Rule:\n" +
                "Instrucations to play this game\n" +
                "Have a good time!";
            //Call messagebox class to dipolay the above messae
            MessageBox.Show(message, title);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //Respond to click event
            //Quit the program
            //pop up a message to display the game instructions
            string title = "Quit?";
            string message = "Are you sure you want to quit the game?";
            //Call messagebox class to dipolay the above messae
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnTopScore_Click(object sender, EventArgs e)
        {
            //Open Top 10 score form on click event
            scorescreen.Show();
            this.Hide();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            game.Show();
        }
    }
}
