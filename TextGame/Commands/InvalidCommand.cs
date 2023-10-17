using System;
using TextGame.Abstract;
using TextGame.States;
using TextGame.Commands;
namespace TextGame.Commands
{
	public class InvalidCommand:ICommand
    {
       
        public void BackToHome()
        {
            var manager = new StateManager();
            var command = new SwitchStateCommand(manager, new MainMenuState(manager));
            command.Execute();
        }
        public void Execute()
        {
            Console.WriteLine("You requested an invalid command");
            BackToHome();
        }
    }
}

