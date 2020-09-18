using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummatieveOpdracht1.Classes
{
    public class Dealer
    {
        private List<Card> deck;
        Deck newDeck = new Deck();


        // Wanneer een nieuwe dealer wordt aangemaakt, worden hier gelijk
        // kaarten aan toegevoegd, in de volgorde zoals deze bij deck gemaakt worden
        public Dealer()
        {
            List<Card> deck = new List<Card>();

            this.deck = newDeck.getAllCards();          
        }

        // De kaarten worden geshuffled en uitgedeeld. Dit door steeds de bovenste kaart
        // uit de delen en deze te verwijderen uit de list (zoals in het echt ook gebeurt)
        public List<List<Card>> kaartenUitdelen()
        {
            deck = newDeck.shuffleCards(deck);

            List<Card> playerOneDeck = new List<Card>();
            List<Card> playerTwoDeck = new List<Card>(); ;
            List<Card> playerThreeDeck = new List<Card>(); ;
            List<Card> playerFourDeck = new List<Card>(); ;

            for (int i = 0; i < 13; i++)
            {
                playerOneDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerTwoDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerThreeDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerFourDeck.Add(deck[0]);
                deck.RemoveAt(0);
            }

            List<List<Card>> returnList = new List<List<Card>>();

            returnList.Add(playerOneDeck);
            returnList.Add(playerTwoDeck);
            returnList.Add(playerThreeDeck);
            returnList.Add(playerFourDeck);

            return returnList;
        }
    }
}