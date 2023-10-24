using System;
using TextGame.Abstract;
namespace TextGame.Commands
{
	public class SwitchStateCommand:ICommand
	{
		private StateManager _manager;
		private IState _state;

		public SwitchStateCommand( StateManager manager,IState state)
		{
			_manager = manager;
			_state = state;
		}

        public void Execute()
        {
			EngineClass.CurrentState = _state;
			_state.Render();
			var command = _state.GetCommand();
			command.Execute();
        }
    }
}

