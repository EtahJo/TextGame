using System;
using System.IO;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class SaveFileCommand:ICommand
	{
        private string _fileName;
		public SaveFileCommand(string fileName)
		{
            _fileName = fileName;
		}

        public void Execute()
        {
            var fileStream= File.Open(_fileName+".txt",FileMode.OpenOrCreate);
            fileStream.Close();
            Console.WriteLine("File Created");
            
        }
    }
}

