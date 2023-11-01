using System;
using TextGame.GameClasses;
namespace TextGame.Commands
{
	public class PickUpItemCommand:ICommand
	{
        private readonly Room _room;
        private readonly IItem _item;

		public PickUpItemCommand(Room room, IItem item)
		{
            _room = room;
            _item = item;
		}
        public PickUpItemCommand(IItem item)
        {
            _item = item;
       
        }

        public void Execute()
        {
            Console.WriteLine("You selected {0}", _item.Name);
            Console.WriteLine("What will you like to do with it ?");
            var request = Console.ReadLine();
            var command = new UseItemCommand(_item, request);
            command.Execute();

        }
    }
}

