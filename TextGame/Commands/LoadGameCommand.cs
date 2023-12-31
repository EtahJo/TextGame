﻿using System;
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
            //EngineClass.CurrentGame = game;
            var stream = File.Open(FileName, FileMode.Open);
            using (var br = new BinaryReader(stream))
            {
                var gameObjectCount = br.ReadInt32();
                var playerId = new Guid(br.ReadBytes(16));
                var player = game.GetGameObject(playerId);

                for(var i = 0; i<gameObjectCount; i++)
                {
                    var id = new Guid(br.ReadBytes(16));
                    var type = (GameObjectType)br.ReadInt32();
                    //Console.WriteLine
                    IGameObject obj = null;
                    switch (type)
                    {
                        case GameObjectType.Room:
                            obj = new Room(id);
                            break;
                        case GameObjectType.Player:
                            obj = new Player(id);
                            break;
                        default:
                            obj = new Player(id);
                            break;
                    }
                    game.AddGameObject(obj);

                }
                foreach(var go in game.GameObjects)
                {
                    go.Load(game, br);
                  
                }
            }
            foreach(var go in game.GameObjects)
            {
                Console.WriteLine("Execute load game");
                Console.WriteLine(game.Player.Name);
                var thePlayer = go as Player;
                if (thePlayer != null)
                {
                    Console.WriteLine("Player is {0}", thePlayer.Name);
                }
                var theRoom = go as Room;
                if (theRoom != null)
                {
                    Console.WriteLine("The room name is {0}", theRoom.Name);
                }
            }
           
        }
    }
}

