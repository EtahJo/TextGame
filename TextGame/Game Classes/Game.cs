using System;
using TextGame.Abstract;
namespace TextGame.GameClasses
{
	public class Game:IGame
	{
		public Player Player { get; set; }
		public List<IGameObject> GameObjects { get; private set; }
		public Game()
		{
			GameObjects = new List<IGameObject>();
		}

		public void AddGameObject(IGameObject go)
		{
			GameObjects.Add(go);
		}

        public IGameObject GetGameObject(Guid id)
        {
			IGameObject gameObject;

			foreach(var go in GameObjects)
			{
				if(go.Id == id)
				{
					gameObject = go;

					return gameObject;
				}
			}
			return null;
        }
    }
}

