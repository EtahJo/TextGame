using System;
namespace TextGame.GameClasses
{
	public class Item:IItem
	{

        public string Name { get; private set; }
        public bool Useable { get; private set; }
        public Item(string name, bool useable)
		{
            Name = name;
            Useable = useable;
		}

    }
}

