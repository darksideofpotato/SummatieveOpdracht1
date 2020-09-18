<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SummatieveOpdracht1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" type="text/css" rel="stylesheet" media="screen" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        
            <!--- image bovenaan -->
            <asp:Image height="250px" class="frontPageImage" src="images/cardimage.png" runat="server" />
         
            <h1> Welkom bij de kaartspel applicatie!</h1>

        <!-- gamestarter div. deze is zichtbaar in het begin, maar na het aanmaken
            van de spelers gaat deze weer weg. -->
        <div id="gameStarter" runat="server">
            <p>Hier kun je een set van 52 kaarten verdelen onder 4 spelers.<br /> Voer
                de namen van deze spelers in om te beginnen!
            </p>

            <div id="textboxesDiv" runat="server">
            <div id="textboxesLeft">
            Speler 1 <asp:TextBox ID="player1" class="textboxes" runat="server"></asp:TextBox><br />
            Speler 2 <asp:TextBox ID="player2" class="textboxes" runat="server"></asp:TextBox><br />
            </div>
            <div id="textboxesRight" runat="server">  
            Speler 3 <asp:TextBox ID="player3" class="textboxes" runat="server"></asp:TextBox><br />
            Speler 4 <asp:TextBox ID="player4" class="textboxes" runat="server"></asp:TextBox><br />
            </div>  
             <asp:Button class="buttons" OnClick="setPlayers" Text="Begin" runat="server" />
            </div>
           
        </div>
    
    
        <asp:Button class="buttons" id="schudKaartenButton" OnClick="schudKaarten" Text="Schud het deck en deel kaarten uit" runat="server" />

        <!-- het speelveld waarin alle knoppen en kaarten komen te staan. Nog geen
            efficientere manier gevonden om meerdere images te tonen-->
    <div id="playField" runat="server">

        <asp:Button class="buttons" id="deckPlayer1" OnClick="deckPlayerOne" Text="Show deck for player one" runat="server" />
        <asp:Button class="buttons" id="deckPlayer2" OnClick="deckPlayerTwo" Text="Show deck for player two" runat="server" />
        <asp:Button class="buttons" id="deckPlayer3" OnClick="deckPlayerThree" Text="Show deck for player three" runat="server" />
        <asp:Button class="buttons" id="deckPlayer4" OnClick="deckPlayerFour" Text="Show deck for player four" runat="server" />
        <div id="images" runat="server">
        <asp:Label ID="shownDeck" class="imageHolders" runat="server" Text=""></asp:Label>
        <asp:Image ID="imagesDeck1" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck2" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck3" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck4" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck5" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck6" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck7" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck8" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck9" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck10" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck11" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck12" class="imageHolders" runat="server" />
        <asp:Image ID="imagesDeck13" class="imageHolders" runat="server" />
        </div>
        </div>

      <asp:Button class="buttons" id="backButton" OnClick="goBack" runat="server" Text="Back to start" />
        </form>
</body>
</html>
