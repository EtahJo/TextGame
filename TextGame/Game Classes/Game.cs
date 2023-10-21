using System;
using TextGame.Abstract;
namespace TextGame.GameClasses
{
	public class Game
	{
		public Player Player { get; set; }
		public List<IGameObject> GameObjects { get; private set; }
		public Game()
		{
			GameObjects = new List<IGameObject>();
		}
	}
}

