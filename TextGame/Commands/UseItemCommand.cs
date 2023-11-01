using System;
namespace TextGame.Commands
{
	public class UseItemCommand:ICommand
	{
        private readonly IItem _item;
        private readonly string _action;
		public UseItemCommand(IItem item, string action)
		{
            _item = item;
            _action = action;
		}

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

