using System;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class NewGameCommand:ICommand
	{
        public string UserName { get; set; }
        public NewGameCommand(string userName)
        {
            UserName = userName;

        }
        public void Execute()
        {
            Console.WriteLine("This is a new game - Enjoy!!");
        }
    }
}

