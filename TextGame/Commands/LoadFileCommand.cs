using System;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class LoadFileCommand:ICommand
	{
        private string _fileName;
		public LoadFileCommand(string fileName)
		{
            _fileName = fileName;
		}

        public void Execute()
        {
            Console.WriteLine("Now Reading the file called {0} ....", _fileName);
        }
    }
}

