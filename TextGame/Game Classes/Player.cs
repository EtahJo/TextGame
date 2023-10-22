using System;
namespace TextGame.GameClasses
{
	public class Player:IGameObject
	{
		public string Name { get; set; }
		public Room CurrentRoom { get; set; }

        public Guid Id { get; private set; }

        public GameObjectType Type { get { return GameObjectType.Player; } }
        public Player (Guid id)
        {
            Id = id;
        }

        public void Save(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(CurrentRoom.Id.ToByteArray());
        }
        public void Load(IGame game, BinaryReader reader)
        {
            Name = reader.ReadString();
            var currentRoomId = new Guid(reader.ReadBytes(16));
            CurrentRoom = (Room)game.GetGameObject(currentRoomId);
        }

       
    }
}

