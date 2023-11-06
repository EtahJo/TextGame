using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class ViewInventoryCommand:ICommand
	{
        private readonly Room _room;
		public ViewInventoryCommand(Room room)
		{
            _room = room;
		}

        public void Execute()
        {
            Console.WriteLine("Below are the items available in room {0}", _room.Name);
            int index = 1;
            foreach(var item in _room.DisplayItems())
            {
                Console.WriteLine("{0}-{1}",index,item.Name);
                index++;
            }
        }
    }
}

