using System;
namespace TextGame.Abstract
{
	public interface IItem:IGameObject
	{
		string Name { get; }
		bool  Useable { get; }
		//bool CheckUseability();
	}
}

