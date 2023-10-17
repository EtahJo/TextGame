using System;
using TextGame.Abstract;
using TextGame.Commands;
namespace TextGame.States
{
	public class SaveFileState:IState
	{
        private StateManager _manager;
        private IState _lastState;
		public SaveFileState(StateManager manager,IState lastState)
		{
            _manager = manager;
            _lastState = lastState;
		}

        public void Render()
        {
            Console.WriteLine("Do you want to go back to the main menu ? -[Back]");
            Console.WriteLine("______________________");
            Console.WriteLine("How will you like to name your file ?");

        }
        public ICommand GetCommand()
        {
            string fileNameOrBack = Console.ReadLine();
            if(fileNameOrBack== "back")
            {
                return new SwitchStateCommand(_manager, _lastState);

            }
            return new SaveFileCommand(fileNameOrBack);
        }

      
    }
}

