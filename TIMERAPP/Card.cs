using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMERAPP
{
    class Card
    {
        //Properties
        private int value;//Ace(1), 2,3,4...,8
        private string suit;//heart(0), diamond(1), club(2), spade(3)
        private Image cardImage;
        private bool faceStatus; //true: face-up; false: face-down
        private bool alive;//true: still visible on screen; false: removed from the screen.
                           //Constructor
        public Card(int value, string suit, Image imageCard, bool faceStatus, bool alive)
        {
            this.value = value;
            this.suit = suit;
            this.cardImage = imageCard;
            this.faceStatus = faceStatus;
            this.alive = alive;
        }
        //Methods
        //Getters and setters
        //Value property
        public void setValue(int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return this.value;
        }
        //Suit property
        public void setSuit(string suit)
        {
            this.suit = suit;
        }
        public string getSuit()
        {
            return this.suit;
        }
        //CardImage property
        public void setCardImage(Image cardImage)
        {
            this.cardImage = cardImage;
        }
        public Image getCardImage()
        {
            return this.cardImage;
        }
        //faceStatus property
        public void setFaceStatus(bool cardStatus)
        {
            this.faceStatus = cardStatus;
        }
        public bool getFaceStatus()
        {
            return this.faceStatus;
        }
        //Alive property
        public void setAlive(bool alive)
        {
            this.alive = alive;
        }
        public bool getAlive()
        {
            return this.alive;
        }
    }
}
