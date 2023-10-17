using System;
using TextGame.Abstract;
using TextGame.Commands;
namespace TextGame.States
{
	public class MainMenuState:IState
	{
        private StateManager _manager;

        public MainMenuState(StateManager manager)
        {
            _manager = manager;
        }

        public void Render()
        {
            Console.WriteLine("Welcome to Etah's Text Game");
            Console.WriteLine("____________________");
            Console.WriteLine("What would you like to try?");
            Console.WriteLine("[Main Menu - M] [Load File - L] [ Launch New Game - G] [Save File - S] [Help - H]" );
        }
        public ICommand GetCommand()
        {
            string command = Console.ReadLine();
            if(command=="H")
            {
                return new HelpCommand();
            }
            if (command == "L")
            {
                return new SwitchStateCommand(_manager, new LoadFileState( _manager,this));
            }
            if(command == "G")
            {
                return new SwitchStateCommand(_manager, new NewGameState(_manager, this));

            }
            if (command == "S")
            {
                return new SwitchStateCommand(_manager, new SaveFileState(_manager,this));

            }

            return new InvalidCommand();
        }

       
    }
}

