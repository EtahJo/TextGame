global using TextGame.Abstract;
using System;
using TextGame.GameClasses;
using TextGame.States;
namespace TextGame
{
    class Program
    {
        static void Main()
        {
            //var game = new Game();
            //var room1 = new Room(Guid.NewGuid());
            //room1.Name = "Room 1";
            //room1.Description = "This is room one";

            //var room2 = new Room(Guid.NewGuid());
            //room2.Name = "Room 2";
            //room2.Description = "This is room two";

            //var player = new Player(Guid.NewGuid());
            //player.Name = "etah";
           

            //game.Player = player;
            //game.Player.CurrentRoom = room1;
            //game.AddGameObject(player);
            //game.AddGameObject(room1);
            //game.AddGameObject(room2);
            var manager = new StateManager();
            manager.Run(new MainMenuState(manager));
            Console.ReadKey();
        }
    }
}
