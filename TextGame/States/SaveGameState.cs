using System;
namespace TextGame.States
{
	public class SaveGameState:IState
	{
		public SaveGameState()
		{
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

            }else if (request == "no")
            {

            }
            return null;
        }

     
    }
}

