using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class DropItemCommand:ICommand
	{
        private readonly Room _room;
        private readonly IItem _item;

		public DropItemCommand(Room room ,IItem item  )
		{
            _room = room;
            _item = item;

		}

        public void Execute()
        {
            _room.AddItem(_item);
            Console.WriteLine("Item added to room");
        }
    }
}

