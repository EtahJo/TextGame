using System;
using System.IO;
using TextGame.Commands;
using TextGame.Abstract;
namespace TextGame.States
{
	public class LoadFileState:IState
	{
        private StateManager _manager;
        private IState _lastState;

        public LoadFileState(StateManager manager, IState lastState)
        {
            _manager = manager;
            _lastState = lastState;

        }
    

        public void Render()
        {
            Console.WriteLine("Go back to main menu - [Back]");
            Console.WriteLine("___________________");
            var directoryInfo = new DirectoryInfo("/Users/etah/Desktop/coding/");
            Console.WriteLine("___________________");
            int index = 1;
        
            foreach (DirectoryInfo info in directoryInfo.GetDirectories())
            {
                Console.WriteLine("{0} - {1}", index, info.Name);
                
                    index++;
            }
            Console.WriteLine("___________________");

            Console.WriteLine("Write down the name of the file you will like to choose");

        }
        public ICommand GetCommand()
        {
            string request = Console.ReadLine();
            if(request== "back")
            {
                return new SwitchStateCommand(_manager,_lastState);
            }
            return new LoadFileCommand(request);
        }

      
    }
}

