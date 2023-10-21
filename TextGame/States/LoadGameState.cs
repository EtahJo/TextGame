using System;
using TextGame.Commands;
using TextGame.GameClasses;
namespace TextGame.States
{
	public class LoadGameState:IState
	{
        public Player Player { get; set; }

		public LoadGameState(Player player)
		{
            Player = player;
		}
        public void Render()
        {
            Console.WriteLine("Would you like to load game or transition to player's room");
        }
        public ICommand GetCommand()
        {
            var request = Console.ReadLine();
            if(request == "load")
            {
                Console.WriteLine("What is the file name?");
                var gameFile = Console.ReadLine();
                return new LoadGameCommand(gameFile,Player);

            }else if (request == "transition")
            {
                var manager = new StateManager();
                return new SwitchStateCommand(manager, new RoomState());
            }
            return null;
        }

      
    }
}

