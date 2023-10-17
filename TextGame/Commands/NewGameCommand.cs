using System;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class NewGameCommand:ICommand
	{
        public void Execute()
        {
            Console.WriteLine("This is a new game - Enjoy!!");
        }
    }
}

