using System;
using TextGame.GameClasses;
using TextGame.Commands;
namespace TextGame.States
{
	public class RoomState:IState
	{
		public Room Room { get; set; }
        public StateManager _manager;

		public RoomState(Room room,StateManager manager)
		{
            Room = room;
            _manager = manager;
		}

        public void Render()
        {
            Console.WriteLine("Room Description - {0}", Room.Description);
            Console.WriteLine("Would you like to load Game or save game");
        }

        public ICommand GetCommand()
        {
            var request = Console.ReadLine();
            if(request == "load")
            {
                return new SwitchStateCommand(_manager, new LoadGameState());
            }else if(request == "save")
            {
                return new SwitchStateCommand(_manager, new SaveGameState());

            }
            return null;
        }
    }
}

