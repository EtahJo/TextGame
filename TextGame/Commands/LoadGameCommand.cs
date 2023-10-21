using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class LoadGameCommand:ICommand
	{
        public string FileName { get; set; }
        public Player Player { get; set; }
		public LoadGameCommand( string fileName,Player player)
		{
            FileName = fileName;
            Player = player;
		}

        public void Execute()
        {
            
        }
    }
}

