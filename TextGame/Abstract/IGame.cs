using System;
namespace TextGame.Abstract
{
	public interface IGame
	{
		IGameObject GetGameObject(Guid id);
	}
}

