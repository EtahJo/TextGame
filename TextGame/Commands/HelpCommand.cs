using System;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class HelpCommand:ICommand
	{
		public HelpCommand()
		{
		}

        public void Execute()
        {
            var inValidCommandInstance = new InvalidCommand();
            Console.WriteLine("Do you want to go back ?");
            Console.WriteLine("_________________");
            Console.WriteLine("How may I be of help ?");
            string request = Console.ReadLine();
            if (request == "back")
            {
                inValidCommandInstance.BackToHome();
            }

        }
    }
}

