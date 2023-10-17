using System;
namespace TextGame.Abstract
{
	public interface IState
	{
		void Render();
		ICommand GetCommand();
	}
}

