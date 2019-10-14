using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMERAPP
{
    class Deck
    {
        1], suits[1], cardImages[1], true, true);//card2
 deck.Add(newCard);//add card2
 newCard = new Card(values[2], suits[2], cardImages[2], true, true);//card3
        deck.Add(newCard);//add card3
 newCard = new Card(values[3], suits[3], cardImages[3], true, true);//card3
        deck.Add(newCard);//add card4
 /*
 for (int i = 0; i < 4; i++)
 {
 //Create a new "Card" object (face-up, alive) and add it to the "deck"
 Card card = new Card(values[i], suits[i], cardImages[i], false, true);
 deck.Add(card);
 }
 */
 }
    //Methods
    //Getters and setters for "deck"
    public void setDeck(List<Card> deck)
    {
        this.deck = deck;
    }
    //
    public List<Card> getDeck()
    {
        return deck;
    }
4
 //shuffle() method randomizes the order of cards in the "deck"
 public void shuffle()
    {
        //The Fisher–Yates shuffle is an algorithm for generating a random permutation of a
        // finite sequence—in plain terms, the algorithm shuffles the sequence.
        Random rand = new Random();
        //For each card in the deck, pick another radnom card and swap them
        for (int first = 0; first < deck.Count; first++)
        {
            //Select a random card
            int second = rand.Next(deck.Count);//Generate a random number between 0 ...N
                                               //Swap the first card and the second card
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
        //Face all cards up & set all cards alive --> CHANGE TO FACE-DOWN FOR REAL GAME
        for (int i = 0; i < deck.Count; i++)
        {
            deck[i].setFaceStatus(true);//face all cards up
            deck[i].setAlive(true);//all cards alive
        }
    }
    //dealCard() method: return the card on top of the "deck"
    public Card dealCard()
    {
        //Check if the "deck" is empty or not
        if (deck.Count > 0)
        {
            //The deck is not empty
            Card cardToBeDealt = deck[deck.Count - 1];//Get the card on top the "deck"
            deck.RemoveAt(deck.Count - 1);//Remove the card being dealt.
            return cardToBeDealt; //Return the card being dealt
        }
        else
        {
            //The deck is empty
            return null;//Return a null card
        }
    }
}
}
