using System;
using System.Xml.Serialization;
using BoardGameLibrary.Data.Base;

namespace BoardGameLibrary.Data.Model
{
    public class Game : DomainObject
    {
        private static int _gameCounter;
		private string _note;
		private string _name;
		private int _plays;
		private float _cost;
		private DateTime _purchased;
		private DateTime _lastPlayed;

	

        public Game()
        {
            _gameCounter++;
            Name = string.Format("Game {0}", _gameCounter);
            Plays = 0;
        }

        public Game(string name)
        {
            Name = name;
            Plays = 0;
        }

        // Copy constructor
        public Game(Game game)
        {
            Name = game.Name;
            Plays = game.Plays;
            Note = game.Note;
			Cost = game.Cost;
			Purchased = game.Purchased;
			LastPlayed = game.LastPlayed;
        }

		public DateTime Purchased {
			get { return _purchased; }
			set { SetField(ref _purchased, value, "Purchased"); }
		}
		public DateTime LastPlayed {
			get { return _lastPlayed; }
			set { SetField(ref _lastPlayed, value, "LastPlayed"); }
		}

		public float Cost {
			get { return _cost;}
			set { SetField(ref _cost, value, "Cost"); }
		}

        public Game Self
        {
            get { return this; }
        }
 
        public string Name
        {
            get { return _name; }
            set { SetField(ref _name, value, "Name"); }
        }

        public int Plays
        {
            get { return _plays; }
            set { SetField(ref _plays, value, "Plays"); }
        }

        public string Note
        {
            get { return _note; }
            set { SetField(ref _note, value, "Note"); }
        }


        public override string ToString()
        {
            return string.Format("{0}[{1}]", Name, Id);
        }
    }
}