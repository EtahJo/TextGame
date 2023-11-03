using System;
using TextGame.GameClasses;
using TextGame.States;
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
            Console.WriteLine("Will you like to use item ?");
            var request = Console.ReadLine();
            if(request== "yes")
            {
                var command = new SwitchStateCommand(new StateManager(), new UseItemState(_item));
                command.Execute();

            }

        }
    }
}

