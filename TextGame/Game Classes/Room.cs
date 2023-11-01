﻿using System;

namespace TextGame.GameClasses
{
	public class Room:IGameObject
	{
		public string Name { get; set; }
		public string Description { get; set; }

        public Guid Id { get; private set; }

        public GameObjectType Type { get{ return  GameObjectType.Room; } }
        private readonly List<IItem> _items;

        public Room (Guid id)
        {
            Id = id;
            _items = new List<IItem>();
        }
        public void AddItem(IItem item)
        {
            _items.Add(item);
           

        }
        public List<IItem> DisplayItems()
        {
            //int index = 1;
            //foreach(var item in _items)
            //{
            //    Console.WriteLine("{0}-{1}",index,item.Name);
            //    index++;
            //}
            return _items;
           

        }
        public void Save(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(Description);
            foreach(var item in _items)
            {
                writer.Write(item.Name);
                writer.Write(item.Useable);
            }
           
        }

        public void Load(IGame game, BinaryReader reader)
        {
            Name = reader.ReadString();
            Description = reader.ReadString();
            foreach (var item in _items)
            {
                reader.ReadString();
                reader.ReadBoolean();
            }
        }

       
    }
}

