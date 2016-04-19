using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameChooser
{
    class BoardGame
    {
        public string Name { get; set; }
        public int MinNumOfPlayers { get; set; }
        public int MaxNumOfPlayers { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public List<GameType> Types { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int MinDuration, int MaxDuration, List<GameType> Types)
        {
            this.Name = Name;
            this.MinNumOfPlayers = MinNumOfPlayers;
            this.MaxNumOfPlayers = MaxNumOfPlayers;
            this.MinDuration = MinDuration;
            this.MaxDuration = MaxDuration;
            this.Types = Types;
        }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int MinDuration, int MaxDuration) : this(Name, MinNumOfPlayers, MaxNumOfPlayers, MinDuration, MaxDuration, new List<GameType>()) { }

        public BoardGame(string Name, int MinNumOfPlayers, int MaxNumOfPlayers, int Duration) : this(Name, MinNumOfPlayers, MaxNumOfPlayers, Duration, Duration) { }

        public enum GameType { Strategy, Tile, War, Dice, Card, Party, CoOp, Lying}
    }
}
