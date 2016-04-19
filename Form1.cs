using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameChooser
{
    public partial class Form1 : Form
    {
        List<BoardGame> boardGames = new List<BoardGame>();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            BoardGame ClassicCatan = new BoardGame("Catan", 3, 6, 60);
            ClassicCatan.Types.Add(BoardGame.GameType.Strategy);
            boardGames.Add(ClassicCatan);

            BoardGame CatanDice = new BoardGame("Catan Dice Game", 1, 4, 15);
            CatanDice.Types.Add(BoardGame.GameType.Dice);
            CatanDice.Types.Add(BoardGame.GameType.Strategy);
            boardGames.Add(CatanDice);

            BoardGame StarTrekCatan = new BoardGame("Star Trek: Catan", 3, 4, 75);
            StarTrekCatan.Types.Add(BoardGame.GameType.Strategy);
            boardGames.Add(StarTrekCatan);

            BoardGame SmallWorld = new BoardGame("Small World", 2, 5, 40, 80);
            SmallWorld.Types.Add(BoardGame.GameType.War);
            SmallWorld.Types.Add(BoardGame.GameType.Strategy);
            boardGames.Add(SmallWorld);

            BoardGame FiveTribes = new BoardGame("Five Tribes", 2, 4, 40, 80);
            boardGames.Add(FiveTribes);

            BoardGame TicketToRide = new BoardGame("Ticket To Ride", 2, 5, 30, 60);
            boardGames.Add(TicketToRide);

            BoardGame TicketToRideEurope = new BoardGame("Ticket To Ride: Europe", 2, 5, 30, 60);
            boardGames.Add(TicketToRideEurope);

            BoardGame TheResistance = new BoardGame("The Resistance", 5, 10, 30);
            TheResistance.Types.Add(BoardGame.GameType.Party);
            TheResistance.Types.Add(BoardGame.GameType.Lying);
            boardGames.Add(TheResistance);

            BoardGame Coup = new BoardGame("Coup", 2, 6, 15);
            Coup.Types.Add(BoardGame.GameType.Card);
            Coup.Types.Add(BoardGame.GameType.Lying);
            boardGames.Add(Coup);

            BoardGame Carcassonne = new BoardGame("Carcassonne", 2, 5, 30, 45);
            Carcassonne.Types.Add(BoardGame.GameType.Tile);
            boardGames.Add(Carcassonne);

            BoardGame Alhambra = new BoardGame("Alhambra", 2, 6, 45, 60);
            Alhambra.Types.Add(BoardGame.GameType.Tile);
            boardGames.Add(Alhambra);

            BoardGame CastlePanic = new BoardGame("Castle Panic", 1, 6, 60);
            CastlePanic.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(CastlePanic);

            BoardGame KingOfTokyo = new BoardGame("King of Tokyo", 2, 6, 30);
            boardGames.Add(KingOfTokyo);

            BoardGame Stratego = new BoardGame("Stratego", 2, 2, 45);
            boardGames.Add(Stratego);

            BoardGame CardsAgainstHumanity = new BoardGame("Cards Aginst Humanity", 4, 10, 30, 90);
            CardsAgainstHumanity.Types.Add(BoardGame.GameType.Party);
            boardGames.Add(CardsAgainstHumanity);

            BoardGame ZombieDice = new BoardGame("Zombie Dice", 2, 10, 30);
            ZombieDice.Types.Add(BoardGame.GameType.Dice);
            boardGames.Add(ZombieDice);

            BoardGame LoveLetter = new BoardGame("Love Letter", 3, 8, 45);
            LoveLetter.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(LoveLetter);

            BoardGame BatmanLoveLetter = new BoardGame("Love Letter: Batman", 2, 4, 20);
            BatmanLoveLetter.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(BatmanLoveLetter);

            BoardGame SmashUp = new BoardGame("Smash Up!", 2, 6, 45);
            SmashUp.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(SmashUp);

            BoardGame StarTrekDeckBuilding = new BoardGame("Star Trek Deck Building Game: The Next Generation – The Next Phase", 2, 4, 90);
            StarTrekDeckBuilding.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(StarTrekDeckBuilding);

            BoardGame SheriffOfKnottingham = new BoardGame("Sheriff of Knottingham", 3, 5, 60);
            SheriffOfKnottingham.Types.Add(BoardGame.GameType.Lying);
            boardGames.Add(SheriffOfKnottingham);

            BoardGame Monopoly = new BoardGame("Monopoly", 2, 6, 90);
            boardGames.Add(Monopoly);

            BoardGame StarWarsMonopoly = new BoardGame("Monopoly: Star Wars", 2, 4, 60);
            boardGames.Add(StarWarsMonopoly);

            BoardGame PokemonMonopoly = new BoardGame("Monopoly: Pokémon Kanto Edition ", 2, 6, 90);
            boardGames.Add(PokemonMonopoly);

            BoardGame MonopolyDeal = new BoardGame("Monopoly Deal Card Game", 2, 5, 15);
            MonopolyDeal.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(MonopolyDeal);

            BoardGame Risk = new BoardGame("Risk", 2, 6, 90);
            Risk.Types.Add(BoardGame.GameType.Strategy);
            Risk.Types.Add(BoardGame.GameType.War);
            Risk.Types.Add(BoardGame.GameType.Dice);
            boardGames.Add(Risk);

            BoardGame StarWarsRisk = new BoardGame("Risk: Star Wars Edition", 2, 4, 60);
            StarWarsRisk.Types.Add(BoardGame.GameType.Strategy);
            StarWarsRisk.Types.Add(BoardGame.GameType.War);
            StarWarsRisk.Types.Add(BoardGame.GameType.Dice);
            boardGames.Add(StarWarsRisk);

            BoardGame BattleShip = new BoardGame("Electronic Battleship Advanced Mission", 1, 2, 45);
            BattleShip.Types.Add(BoardGame.GameType.War);
            boardGames.Add(BattleShip);

            BoardGame Pandemic = new BoardGame("Pandemic", 2, 4, 45);
            Pandemic.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(Pandemic);

            BoardGame ElderSign = new BoardGame("Elder Sign", 1, 8, 60, 120);
            ElderSign.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(ElderSign);

            BoardGame CastleRavenloft = new BoardGame("Dungeons & Dragons: Castle Ravenloft Board Game", 1, 5, 60);
            CastleRavenloft.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(CastleRavenloft);

            BoardGame LefendofDrizzt = new BoardGame("Dungeons & Dragons: The Legend of Drizzt Board Game", 1, 5, 60);
            LefendofDrizzt.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(LefendofDrizzt);

            BoardGame Munchkin = new BoardGame("Munchkin", 3, 6, 60, 120);
            Munchkin.Types.Add(BoardGame.GameType.Party);
            boardGames.Add(Munchkin);

            BoardGame ForbiddenIsland = new BoardGame("Forbidden Island", 2, 4, 30);
            ForbiddenIsland.Types.Add(BoardGame.GameType.CoOp);
            boardGames.Add(ForbiddenIsland);

            BoardGame SkipBo = new BoardGame("Skip Bo", 2, 6, 30);
            SkipBo.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(SkipBo);

            BoardGame FormulaD = new BoardGame("Formula D", 2, 10, 60);
            FormulaD.Types.Add(BoardGame.GameType.Dice);
            boardGames.Add(FormulaD);

            BoardGame PokemonCards = new BoardGame("Pokemon Cards", 2, 2, 45);
            PokemonCards.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(PokemonCards);

            BoardGame MagicCards = new BoardGame("Magic Cards", 2, 2, 50);
            MagicCards.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(MagicCards);

            BoardGame Dixit = new BoardGame("Dixit", 3, 6, 30);
            Dixit.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(Dixit);

            BoardGame SushiGo = new BoardGame("Sushi Go!", 2, 5, 15);
            SushiGo.Types.Add(BoardGame.GameType.Card);
            boardGames.Add(SushiGo);

            MessageBox.Show(boardGames.Select(x => x.Name)
                                      .OrderBy(x => x)
                                      .Aggregate((x, y) => (x + Environment.NewLine + y)), "All the Board Games!");

            this.Text = "Randomly choose a board game from all " + boardGames.Count.ToString() + " games!";

            this.numPlayers.Minimum = boardGames.Select(x => x.MinNumOfPlayers).Min();
            this.numPlayers.Maximum = boardGames.Select(x => x.MaxNumOfPlayers).Max();

            this.numMinMinutes.Minimum = boardGames.Select(x => x.MinDuration).Min();
            this.numMinMinutes.Maximum = boardGames.Select(x => x.MinDuration).Max();

            this.numMaxMinutes.Minimum = boardGames.Select(x => x.MaxDuration).Min();
            this.numMaxMinutes.Maximum = boardGames.Select(x => x.MaxDuration).Max();

            this.numMinMinutes.Value = this.numMinMinutes.Minimum;
            this.numMaxMinutes.Value = this.numMaxMinutes.Maximum;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            List<BoardGame> possibles = boardGames.Where(game => game.MinDuration >= numMinMinutes.Value && game.MaxDuration <= numMaxMinutes.Value)
                                                  .Where(game => game.MinNumOfPlayers <= numPlayers.Value && game.MaxNumOfPlayers >= numPlayers.Value)
                                                  .ToList();

            if (possibles.Count == 0)
            {
                MessageBox.Show("No possible Games!", "No Games!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(possibles[rand.Next(0, possibles.Count)].ToString(), "Chosen Game");
            }
                      
        }
    }
}
