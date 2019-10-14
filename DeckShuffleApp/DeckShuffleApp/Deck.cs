using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeckShuffleApp
{
    class Deck
    {
        //Properties
        private Card[] deck; //An array contains all cards
        private int topCardIndex;//Index of the card on the top of deck, also the next card to be delt.

        //Constructor
        public Deck()
        {
            //Define all the card properties
            int[] values = {1,2,3,4,5,6,7,8};
            string[] suits = {"heart", "diamond", "club", "spade" };
            Image[] cardImages = {Properties.Resources.heart1, Properties.Resources.heart2, Properties.Resources.heart3,
                                Properties.Resources.heart4, Properties.Resources.heart5, Properties.Resources.heart6,
                                Properties.Resources.heart7, Properties.Resources.heart8};

            //Create all cards and assign them to "deck"
            deck = new Card[8];
            for (int value = 1; value <= values.Max(); value++)
            {
                Card card = new Card(value, suits[0], cardImages[value - 1], false);//Create a new card
                deck[value - 1] = card; //Assign the new card to the "deck"
            }
        }

        //Methods
        public void shuffle()
        {
            //The Fisher–Yates shuffle is an algorithm for generating a random permutation of a finite sequence—in plain terms, 
            //the algorithm shuffles the sequence.
            Random rand = new Random();

            //For each card in the deck, pick another radnom card and swap them
            for (int first = 0; first < 8; first++)
            {
                //Select a random card
                int second = rand.Next(8);//Generate a random number between 0 ...7
                //Swap the first card and the second card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card dealCard()
        {
            //.......
            Card card = null;
            return card;
        }

        //Getters and setters
        public void setDeck(Card[] deck)
        {
            this.deck = deck;
        }
        public Card[] getDeck() {
            return deck;   
        }
        public void setTopCardIndex(int topCardIndex)
        {
            this.topCardIndex = topCardIndex;
        } public int getTopCardIndex()
        {
            return this.topCardIndex;
        }


    }
}
