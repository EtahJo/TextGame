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
            Console.WriteLine("_________________");
            Console.WriteLine("Would you like to Drop/Pick Item in room");
        }

        public ICommand GetCommand()
        {
            var request = Console.ReadLine();
            if(request == "load")
            {
                return new SwitchStateCommand(_manager, new LoadGameState());
            }
           else  if (request == "drop")
            {
                Console.WriteLine("Item name ?");
                var ItemName = Console.ReadLine();
                Console.WriteLine("Is item useable?");
                var useabilityResponse = Console.ReadLine();
                var useability = useabilityResponse == "yes" ? true : false; 

                return new DropItemCommand(Room,new Item(ItemName,useability));
            }
            else if (request == "pick")
            {
                Console.WriteLine("_______________");
                Console.WriteLine("Below are the list of items you have in this room, select one");
                int index = 1;
                var roomItems = Room.DisplayItems();
                foreach (var item in roomItems)
                {
                    Console.WriteLine("{0} - {1}",index, item.Name);
                    index++;

                }
                int userPick;
                if(int.TryParse(Console.ReadLine(), out userPick)){
                  
                    return new PickUpItemCommand(roomItems[userPick-1]);
                }
                
            }

            //else if(request == "save")
            //{
            //    return new SwitchStateCommand(_manager, new SaveGameState());

            //}
            return null;
        }
    }
}

