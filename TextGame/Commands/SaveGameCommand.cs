using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class SaveGameCommand:ICommand
	{
        public string FileName { get; private set; }
        public Game Game { get; private set; }
		public SaveGameCommand(string fileName,Game game)
		{
            FileName = fileName;
            Game = game;
		}

        public void Execute()
        {
            var stream = File.Open(FileName, FileMode.OpenOrCreate);
            using (var bw = new BinaryWriter(stream))
            {
                bw.Write(Game.GameObjects.Count);
                bw.Write(Game.Player.Id.ToByteArray());
              
                foreach(var go in Game.GameObjects)
                {
                    bw.Write(go.Id.ToByteArray());
                    bw.Write((int)go.Type);
                    go.Save(bw);
                }
            }
            Console.WriteLine("______________");
            Console.WriteLine("Your game was saved");
            var commandInstance= new InvalidCommand();
            commandInstance.BackToHome();

            
        }
    }
}

