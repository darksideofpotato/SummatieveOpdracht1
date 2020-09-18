using SummatieveOpdracht1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SummatieveOpdracht1
{
    public partial class index : System.Web.UI.Page
    {
        static Game thisGame = new Game();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            // Wanneer de applicatie opgestart wordt, wordt de 'playfield'
            // en 'schudkaartenbutton' onzichtbaar gemaakt. Er is hiervoor gekozen
            // in plaats van meerdere pagina's om het simpel te houden voor de eerste
            // inleveropdracht.

            schudKaartenButton.Visible = false;
            playField.Visible = false;
        }

        protected void setPlayers(object sender, EventArgs e)
        {
            // Wanneer de playernames zijn ingevuld en op de knop wordt
            // gedrukt worden de objecten aangemaakt van de class player
            Player playerOne = new Player(1, player1.Text);
            thisGame.addToPlayers(playerOne);
            Player playerTwo = new Player(1, player2.Text);
            thisGame.addToPlayers(playerTwo);
            Player playerThree = new Player(1, player3.Text);
            thisGame.addToPlayers(playerThree);
            Player playerFour = new Player(1, player4.Text);
            thisGame.addToPlayers(playerFour);

            //De button om kaarten de schudden wordt zichtbaar, en de invulvelden
            // onzichtbaar. 
            schudKaartenButton.Visible = true;
            gameStarter.Visible = false;
            
        }

        protected void schudKaarten(object sender, EventArgs e)
        {
            //De kaarten worden geschud en uitgedeeld. Het speelveld wordt zichtbaar
            List<List<Card>> shuffledDeck = thisGame.getDealer().kaartenUitdelen();
            playField.Visible = true;

            List<Player> players = thisGame.getPlayers();


            foreach (Player player in players)
            {

                player.setHand(shuffledDeck[0]);

                shuffledDeck.RemoveAt(0);

            }

            schudKaartenButton.Visible = false;
        }

        // Voor de volgende 4 buttons worden alle kaarten zichtbaar gemaakt in image
        // holders door middel van foreach loops.
        protected void deckPlayerOne(object sender, EventArgs e)
        {
            playField.Visible = true;
            shownDeck.Text = "";
            List<Player> players = thisGame.getPlayers();

            List<Card> hand = players[0].getHand();

            int counter = 1;

            foreach (Card card in hand)
            {

                string theImage = card.translateCardsToImages();

                Image imageHolder = (Image)this.FindControl("imagesDeck" + counter.ToString());

                imageHolder.ImageUrl = "images/" + theImage;

                counter += 1;
            }

        }

        protected void deckPlayerTwo(object sender, EventArgs e)
        {
            playField.Visible = true;
            shownDeck.Text = "";
            List<Player> players = thisGame.getPlayers();

            List<Card> hand = players[1].getHand();

            int counter = 1;

            foreach (Card card in hand)
            {

                string theImage = card.translateCardsToImages();

                Image imageHolder = (Image)this.FindControl("imagesDeck" + counter.ToString());

                imageHolder.ImageUrl = "images/" + theImage;

                counter += 1;
            }

        }

        protected void deckPlayerThree(object sender, EventArgs e)
        {
            playField.Visible = true;
            shownDeck.Text = "";
            List<Player> players = thisGame.getPlayers();

            List<Card> hand = players[2].getHand();

            int counter = 1;

            foreach (Card card in hand)
            {
  
                string theImage = card.translateCardsToImages();

                Image imageHolder = (Image)this.FindControl("imagesDeck" + counter.ToString());

                imageHolder.ImageUrl = "images/" + theImage;

                counter += 1;
            }

        }

        protected void deckPlayerFour(object sender, EventArgs e)
        {
            playField.Visible = true;
            shownDeck.Text = "";

            List<Player> players = thisGame.getPlayers();

            List<Card> hand = players[3].getHand();

            int counter = 1;

            foreach (Card card in hand)
            {

                string theImage = card.translateCardsToImages();

                 Image imageHolder = (Image)this.FindControl("imagesDeck" + counter.ToString());

                imageHolder.ImageUrl = "images/" + theImage;

                counter += 1;
            }

        }

        //De button gaat terug naar het begin en cleared alle aangemaakte gegevens.
        // Niet de netste manier, maar voldoet voor nu
        protected void goBack(object sender, EventArgs e)
        {
            System.Web.HttpRuntime.UnloadAppDomain();
            gameStarter.Visible = true;
        }

   
    }
}