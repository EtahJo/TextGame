global using TextGame.Abstract;
using System;
using TextGame.States;
namespace TextGame
{
    class Program
    {
        static void Main()
        {
            var manager = new StateManager();
            manager.Run(new MainMenuState(manager));
            Console.ReadKey();
        }
    }
}
