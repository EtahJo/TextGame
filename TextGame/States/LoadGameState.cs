using System;
using TextGame.Commands;
using TextGame.GameClasses;
namespace TextGame.States
{
	public class LoadGameState:IState
	{
        public Player Player { get; set; }

		public LoadGameState()
		{
          
		}
        public void Render()
        {
            Console.WriteLine("What is the name of the game file? ");
        }
        public ICommand GetCommand()
        {
            var fileName = Console.ReadLine();
            if(fileName != "")
            {
                var gameFileName = Console.ReadLine();
                return new LoadGameCommand(gameFileName);
            }
            return null;
        }

      
    }
}

