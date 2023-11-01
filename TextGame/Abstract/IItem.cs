using System;
namespace TextGame.Abstract
{
	public interface IItem
	{
		string Name { get; }
		bool  Useable { get; }
		//bool CheckUseability();
	}
}

