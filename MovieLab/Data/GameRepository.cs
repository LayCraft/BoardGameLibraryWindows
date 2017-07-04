using System.ComponentModel;
using BoardGameLibrary.Data.Base;
using BoardGameLibrary.Data.Model;

namespace BoardGameLibrary.Data
{
    public class GameRepository : RepositoryBase
    {
        private readonly BindingList<Game> _games = new BindingList<Game>();
        
        public GameRepository()
        {
            AddBindingList(typeof(Game), Games);
        }



        public BindingList<Game> Games
        {
            get { return _games; }
        }
    }
}
