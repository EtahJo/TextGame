using System;
using TextGame.GameClasses;
using TextGame.Commands;
namespace TextGame.States
{
	public class ViewInventaryState:IState
	{
        private readonly Game _game;
        private readonly List<Room> _rooms;
		public ViewInventaryState(Game game)
		{
            _game = game;
            _rooms = new List<Room>();
		}
        public void Render()
        {
            Console.WriteLine("below are the rooms you have in your game?");
            int index = 1;
            foreach(var item in _game.GameObjects)
            {
                var room = item as Room;

           
                if (room != null)
                {
                    var itemCount = room.GetRoomItemCount();
                    Console.WriteLine("{0} {1} - {2} items", index, room.Name, itemCount);
                    _rooms.Add(room);
                }
               
                index++;
            }
            Console.WriteLine("__________________");
            Console.WriteLine("Select room to view available  items");
        }

        public ICommand GetCommand()
        {
            int roomNumber;
           return  int.TryParse(Console.ReadLine(),out roomNumber)?
          new ViewInventoryCommand(_rooms[roomNumber-1]):null;
        }

       
    }
}

