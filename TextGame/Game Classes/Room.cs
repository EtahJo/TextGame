using System;

namespace TextGame.GameClasses
{
	public class Room:IGameObject
	{
		public string Name { get; set; }
		public string Description { get; set; }

        public Guid Id { get; private set; }

        public GameObjectType Type { get{ return  GameObjectType.Room; } }

        public Room (Guid id)
        {
            Id = id;
        }
        public void Save(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(Description);
        }

        public void Load(IGame game, BinaryReader reader)
        {
            Name = reader.ReadString();
            Description = reader.ReadString();
        }

       
    }
}

