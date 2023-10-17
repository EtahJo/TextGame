using System;
using TextGame.Abstract;
using TextGame.Commands;
namespace TextGame.States
{
	public class NewGameState:IState
	{
        private StateManager _manager;
        private IState _lastState;
		public NewGameState( StateManager manager, IState lastState)
		{
            _manager = manager;
            _lastState = lastState;
		}

        public void Render()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("Go back to main menu - [Back]");
            Console.WriteLine("_____________________");
            Console.WriteLine("Do you want to proceed to new game?? - [Yes/No]");
        }

        public ICommand GetCommand()
        {
            string request = Console.ReadLine();
            if (request == "back" || request == "No")
            {
                return new SwitchStateCommand(_manager, _lastState);
            }
            if (request == "yes")
            {
                return new NewGameCommand();
            }
            return new InvalidCommand();
            
        }

      
    }
}

