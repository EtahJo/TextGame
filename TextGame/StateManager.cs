using System;
using TextGame.Abstract;
namespace TextGame
{
	public class StateManager
	{
		//private IState _state;
		public StateManager()
		{
		}

		public void Run(IState state)
		{
			state.Render();
			var command = state.GetCommand();
			command.Execute();
		}
	}
}

