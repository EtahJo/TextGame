using System;
namespace TextGame.States
{
	public class UseItemState:IState
	{
        private readonly IItem _item;
		public UseItemState(IItem item)
		{
            _item = item;
		}
        public void Render()
        {
            Console.WriteLine("What will you like to do with {0}", _item.Name);
        }
        public ICommand GetCommand()
        {
            var request = Console.ReadLine();
            if (request == "move")
            {

            }
            throw new NotImplementedException();
        }

       
    }
}

