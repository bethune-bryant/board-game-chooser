using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameChooser
{
    [Serializable]
    public class BoardGame : IComparable
    {
        public enum GameType { AbstractStrategy, Customizable, Thematic, Family, Childrens, Party, Strategy, War }
        public enum GameCategory { AbstractStrategy, Action_Dexterity, Adventure, AgeofReason, AmericanCivilWar, AmericanIndianWars, AmericanRevolutionaryWar, AmericanWest, Ancient, Animals, Arabian, Aviation_Flight, Bluffing, Book, CardGame, ChildrensGame, CityBuilding, CivilWar, Civilization, CollectibleComponents, ComicBook_Strip, Deduction, Dice, Economic, Educational, Electronic, Environmental, ExpansionforBase_game, Exploration, FanExpansion, Fantasy, Farming, Fighting, GameSystem, Horror, Humor, Industry_Manufacturing, KoreanWar, Mafia, Math, Mature_Adult, Maze, Medical, Medieval, Memory, Miniatures, ModernWarfare, Movies_TV_Radiotheme, Murder_Mystery, Music, Mythology, Napoleonic, Nautical, Negotiation, Novel_based, Number, PartyGame, PikeandShot, Pirates, Political, Post_Napoleonic, Prehistoric, PrintandPlay, Puzzle, Racing, Real_time, Religious, Renaissance, ScienceFiction, SpaceExploration, Spies_SecretAgents, Sports, TerritoryBuilding, Trains, Transportation, Travel, Trivia, VideoGameTheme, VietnamWar, Wargame, WordGame, WorldWarI, WorldWarII, Zombies }
        public enum GameMechanism { Acting,Action_MovementProgramming,ActionPointAllowanceSystem,AreaControl_AreaInfluence,AreaEnclosure,AreaMovement,Area_Impulse,Auction_Bidding,Betting_Wagering,Campaign_BattleCardDriven,CardDrafting,Chit_PullSystem,Co_operativePlay,CommoditySpeculation,CrayonRailSystem,Deck_PoolBuilding,DiceRolling,GridMovement,HandManagement,Hex_and_Counter,LineDrawing,Memory,ModularBoard,Paper_and_Pencil,Partnerships,PatternBuilding,PatternRecognition,Pick_upandDeliver,PlayerElimination,PointtoPointMovement,PressYourLuck,Rock_Paper_Scissors,RolePlaying,Roll_SpinandMove,Route_NetworkBuilding,SecretUnitDeployment,SetCollection,Simulation,SimultaneousActionSelection,Singing,StockHolding,Storytelling,TakeThat,TilePlacement,TimeTrack,Trading,Trick_taking,VariablePhaseOrder,VariablePlayerPowers,Voting,WorkerPlacement }

        public string Name { get; set; }
        public int MinNumOfPlayers { get; set; }
        public int MaxNumOfPlayers { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public List<GameType> Types { get; set; }
        public List<GameCategory> Categories { get; set; }
        public List<GameMechanism> Mechanisms { get; set; }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int MinDuration, int MaxDuration, List<GameType> Types, List<GameCategory> Categories, List<GameMechanism> Mechanisms)
        {
            this.Name = Name;
            this.MinNumOfPlayers = MinNumOfPlayers;
            this.MaxNumOfPlayers = MaxNumOfPlayers;
            this.MinDuration = MinDuration;
            this.MaxDuration = MaxDuration;
            this.Types = Types;
            this.Categories = Categories;
            this.Mechanisms = Mechanisms;
        }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int MinDuration, int MaxDuration) : this(Name, MinNumOfPlayers, MaxNumOfPlayers, MinDuration, MaxDuration, new List<GameType>(), new List<GameCategory>(), new List<GameMechanism>()) { }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int Duration) : this(Name, MinNumOfPlayers, MaxNumOfPlayers, Duration, Duration) { }

        public BoardGame() : this("", 0, 0, 0) { }

        #region Interfaces

        int IComparable.CompareTo(object obj)
        {
            BoardGame input = obj as BoardGame;

            if (obj == null)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Name.CompareTo(input.Name);
            }
        }

        #endregion

        public object AsRow
        {
            get
            {
                return new { Name, MinNumOfPlayers, MaxNumOfPlayers, MinDuration, MaxDuration, Types = ListString(Types), Categories = ListString(Categories), Mechanisms = ListString(Mechanisms) };
            }
        }

        private string ListString<T>(List<T> list)
        {
                return list.Select(x => x.ToString())
                           .Aggregate(string.Empty, (current, next) => current + "," + next);
        }

        public override bool Equals(object obj)
        {
            BoardGame input = obj as BoardGame;

            if (obj == null) return false;

            return this.Name.Equals(input.Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
