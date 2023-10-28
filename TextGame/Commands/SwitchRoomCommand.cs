using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class SwitchRoomCommand:ICommand
	{
        public Game Game { get; set; }
        public string NewRoom { get; set; }
		public SwitchRoomCommand(Game game, string newRoom)
		{
            Game = game;
            NewRoom = newRoom;
		}

        public void Execute()
        {
            foreach(var item in Game.GameObjects)
            {
                var room = item as Room;
                if (room !=null && room.Name == NewRoom)
                {
                    Game.Player.CurrentRoom = room;
                }

               
            }
            Console.WriteLine("You are now in room {0}", Game.Player.CurrentRoom.Name);

        }
    }
}

