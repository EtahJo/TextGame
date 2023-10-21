using System;
namespace TextGame.GameClasses
{
	public class Player:IGameObject
	{
		public string Name { get; set; }
		public Room CurrentRoom { get; set; }
	}
}

