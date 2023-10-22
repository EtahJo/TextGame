using System;
namespace TextGame.Abstract
{
	public interface IGameObject
	{
		Guid Id { get; }
		GameObjectType Type { get; }
		void Save(BinaryWriter writer);
		void Load(IGame game, BinaryReader reader);
	}
}

