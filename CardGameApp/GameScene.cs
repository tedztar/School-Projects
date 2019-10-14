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
    public partial class GameScene : Form
    {
        //Declare Glocab Variables
        //Declare a variavble to store the card face status
        static bool cardFace;
        static Image[] cardImage;
        static PictureBox[] cardBoxes;
        static bool[] cardFaces;//Declare an array that invldes all picture bos

        public GameScene()
        {
            InitializeComponent();
            //Inisialize all gloval variables
            cardFace = false;
            cardImage = new Image[4] {Properties.Resources.card_heart1,
                                    Properties.Resources.card_diamond1,
                                    Properties.Resources.card_club1,
                                    Properties.Resources.card_spade1};
            //add all pictureBox to the array
            cardBoxes = new PictureBox[4] {card1, card2, card3, card4 };
            cardFaces = new bool[4] {false,false,false,false};
                
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            //Flip the card oreantation
            PictureBox clickedCard = sender as PictureBox;
            int clickedCardTag = Convert.ToInt32(clickedCard.Tag);

            if (cardFaces[clickedCardTag] == false)
            {
                clickedCard.Image = cardImage[clickedCardTag];
                cardFaces[clickedCardTag] = true;
            }
            else
            {
                clickedCard.Image = Properties.Resources.card_back;
                cardFaces[clickedCardTag] = false;
            }
        }

        private void BtnDisapear_Click(object sender, EventArgs e)
        {
            card1.Visible = false;
        }

        private void BtnAppear_Click(object sender, EventArgs e)
        {
            card1.Visible = true;
        }
    }
}
