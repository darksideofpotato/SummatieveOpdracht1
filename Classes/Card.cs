using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SummatieveOpdracht1.Classes
{
    public class Card
    {
        private string suit;
        private int rank;
        private int deck;
        private string player;

        public Card(string givenSuit, int givenRank)
        {
            suit = givenSuit;
            rank = givenRank;
            deck = 0;
            // Player krijgt hier nog even een random string, aangezien
            // hij geen lege string wilde accepteren. Bij setplayer
            // wordt er een player toegewezen
            player = "a";
        }
        public void setPlayer(string inputplayer)
        {
            player = inputplayer;
        }

        public string getSuit()
        {
            return suit;
        }
        public int getRank()
        {
            return rank;
        }
        public int getDeck()
        {
            return deck;
        }
        public string getPlayer()
        {
            return player;
        }
        // de objecten worden hier omgezet naar strings die kunnen worden
        // gebruikt als image urls. 
        public string translateCardsToImages()
        {
                string theSuit;

                switch (this.suit)
                {
                    case "clubs":
                        theSuit = "C";
                        break;
                    case "hearts":
                        theSuit = "H";
                        break;
                    case "diamonds":
                        theSuit = "D";
                        break;
                    case "spades":
                        theSuit = "S";
                        break;
                    default:
                        theSuit = "error";
                        break;
                }

                string theNumber = this.rank.ToString();

                string imageCard = (theNumber + theSuit + ".png");
            

            return imageCard;
        }
    }
}