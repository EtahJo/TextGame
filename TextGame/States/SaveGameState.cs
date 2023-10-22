using System;
using TextGame.Commands;
using TextGame.GameClasses;
namespace TextGame.States
{
    public class SaveGameState : IState
    {
        public Game  Game{get;set;}
		public SaveGameState(Game game)
		{
            Game = game;
		}
        public void Render()
        {
            Console.WriteLine("Are you sure you want to save game? (yes/no)");
        }

        public ICommand GetCommand()
        {
            string request = Console.ReadLine();
            if (request == "yes")
            {
                Console.WriteLine("_____________");
                Console.WriteLine("Under what name");
                string fileName = Console.ReadLine();
                if (fileName != " ")
                {
                    return  new SaveGameCommand(fileName,Game);

                }

            }
            else if (request == "no")
            {
                var manager = new StateManager();
                return new SwitchStateCommand(manager, new MainMenuState(manager));
            }
            return null;
        }

     
    }
}

