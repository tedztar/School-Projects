using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckShuffleApp
{
    public partial class Form1 : Form
    {
        //Declare global variables
        static Deck deck = new Deck();
        PictureBox[] cardBoxs;

        public Form1()
        {
            InitializeComponent();

            cardBoxs = new PictureBox[8] {card1, card2, card3, card4, card5, card6, card7, card8};

            //Display all cards on game scene
            /*
            card1.Image = deck.getDeck()[0].getCardImage();
            card2.Image = deck.getDeck()[1].getCardImage();
            card3.Image = deck.getDeck()[2].getCardImage();
            card4.Image = deck.getDeck()[3].getCardImage();
            card5.Image = deck.getDeck()[4].getCardImage();
            card6.Image = deck.getDeck()[5].getCardImage();
            card7.Image = deck.getDeck()[6].getCardImage();
            card8.Image = deck.getDeck()[7].getCardImage();
            */
            for (int i = 0; i < 8; i++)
            {
                cardBoxs[i].Image = deck.getDeck()[i].getCardImage();
            }
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            //Call to execute the shuffle() method
            deck.shuffle();
            //Diplay again the cards
            /*
            card1.Image = deck.getDeck()[0].getCardImage();
            card2.Image = deck.getDeck()[1].getCardImage();
            card3.Image = deck.getDeck()[2].getCardImage();
            card4.Image = deck.getDeck()[3].getCardImage();
            card5.Image = deck.getDeck()[4].getCardImage();
            card6.Image = deck.getDeck()[5].getCardImage();
            card7.Image = deck.getDeck()[6].getCardImage();
            card8.Image = deck.getDeck()[7].getCardImage();
            */

            for (int i=0; i < 8; i++)
            {
                cardBoxs[i].Image = deck.getDeck()[i].getCardImage();
            }


        }

        private void card_Click(object sender, EventArgs e)
        {
            PictureBox cardBox = sender as PictureBox;
            int cardNumber = Convert.ToInt32(cardBox.Tag);
            
            //faceStatus: true: face-up, false: face-down
            if (deck.getDeck()[cardNumber].getFaceStatus() == true)
            {
                cardBox.Image = deck.getDeck()[cardNumber].getCardImage();
                deck.getDeck()[cardNumber].setFaceStatus(false);
            } else
            {
                cardBox.Image = Properties.Resources.cardback;
                deck.getDeck()[cardNumber].setFaceStatus(true);
            } 
            
        }
    
    }
}
