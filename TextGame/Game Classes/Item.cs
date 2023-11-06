using System;

namespace TextGame.GameClasses
{
	public class Item:IItem
	{

        public string Name { get; private set; }
        public bool Useable { get; private set; }

        public Guid Id { get; private set; }

        public GameObjectType Type { get { return GameObjectType.Item; } }
        public Item(string name, bool useable)
		{
            Name = name;
            Useable = useable;
		}

        public void Save(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void Load(IGame game, BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}

