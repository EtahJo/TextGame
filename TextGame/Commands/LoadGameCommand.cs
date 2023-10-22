using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class LoadGameCommand:ICommand
	{
        public string FileName { get; set; }
      
		public LoadGameCommand( string fileName)
		{
            FileName = fileName;
            
		}

        public void Execute()
        {
            var game = new Game();
            var stream = File.Open(FileName, FileMode.Open);
            using (var br = new BinaryReader(stream))
            {
                var gameObjectCount = br.ReadInt32();
                var playerId = new Guid(br.ReadBytes(16));
                var player = game.GetGameObject(playerId);
            }
        }
    }
}

