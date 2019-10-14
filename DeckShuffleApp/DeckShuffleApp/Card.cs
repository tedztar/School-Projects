using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeckShuffleApp
{
    class Card
    {
        //Properties
        private int value;//Ace(1), 2,3,4...,8
        private string suit;//heart(0), diamond(1), club(2), spade(3)
        private Image cardImage;
        private bool faceStatus; //true: face-up, false: face-down

        //Constructor
        public Card(int value, string suit, Image imageCard, bool faceStatus) {
            this.value = value;
            this.suit = suit;
            this.cardImage = imageCard;
            this.faceStatus = faceStatus;
        }

        //Methods
        //Getters and setters
        public void setValue (int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return this.value;
        }
        public void setSuit(string suit)
        {
            this.suit = suit;
        }
        public string getSuit()
        {
            return this.suit;
        }
        public void setCardImage(Image cardImage)
        {
            this.cardImage = cardImage;
        }
        public Image getCardImage()
        {
            return this.cardImage;
        }
        public void setFaceStatus(bool cardStatus)
        {
            this.faceStatus = cardStatus;
        }
        public bool getFaceStatus()
        {
            return this.faceStatus;
        }




    }
}
