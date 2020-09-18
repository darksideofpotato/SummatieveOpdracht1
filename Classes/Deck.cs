using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummatieveOpdracht1.Classes
{
    public class Deck
    {
        private int deckGrootte;
        private List<Card> cards;
        private List<Card> shuffledCards;

        //Constructor
        public Deck()
        {
            this.deckGrootte = 52;
            this.cards = cards;
        }

        public List<Card> getAllCards()
        {
            // Functie die alle kaarten in het spel brengt. Maakt een range van
            // 1 tot 13 (aantal ranks), en maakt voor elke suit 13 hiervan aan
            // en stopt ze vervolgens in de 'cards' list. 
            cards = new List<Card>();

            IEnumerable<int> ranks = Enumerable.Range(1, 13);

            foreach (int rank in ranks)
            {
                cards.Add(new Card("clubs", rank));
                cards.Add(new Card("hearts", rank));
                cards.Add(new Card("spades", rank));
                cards.Add(new Card("diamonds", rank));
            }

            return cards;
        }


        // Met onderstaande methode worden de kaarten van de huidige lijst (alles op nette volgorde aangemaakt)
        // gepakt en geshuffeld. Deze lijst wordt in een nieuwe lijst 'shuffledcards' gestopt. 
        Random rng = new Random();
        public List<Card> shuffleCards(List<Card> unshuffledCards)
        {
            int n = unshuffledCards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = unshuffledCards[k];
                unshuffledCards[k] = unshuffledCards[n];
                unshuffledCards[n] = value;
            }

            shuffledCards = unshuffledCards;

            return shuffledCards;
        }
    }
}