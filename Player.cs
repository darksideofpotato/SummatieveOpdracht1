using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummatieveOpdracht1.Classes
{
    public class Player
        // class player, hier gebeurt weinig spannends buiten wat
        // attributen, de constructor en een aantal gets en sets
    {
        private int id;
        private string name;
        private List<Card> hand;

        public Player(int inputId, string inputName)
        {
            this.id = inputId;
            this.name = inputName;
        }

        public string getName()
        {
            return name;
        }
        public void setHand(List<Card> kaarten)
        {
            this.hand = kaarten;
        }
        public List<Card> getHand()
        {
            return hand;
        }
        public void setNaam(string inputName)
        {
            this.name = inputName;
        }
    }
}