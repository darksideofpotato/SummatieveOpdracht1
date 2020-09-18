using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummatieveOpdracht1.Classes
{
    public class Game
    {
            private Dealer dealer;
            private List<Player> players;

            public Game()
            {
                this.dealer = new Dealer();
                this.players = new List<Player>();
            }
            
        public void addToPlayers(Player player)
        {
            players.Add(player);
        }
        public List<Player> getPlayers()
        {
            return this.players;
        }
        public Dealer getDealer()
        {
            return this.dealer;
        }
    }
}