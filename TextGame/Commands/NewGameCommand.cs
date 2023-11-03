using System;
using TextGame.GameClasses;
using TextGame.States;
namespace TextGame.Commands
{
    public class NewGameCommand : ICommand
    {
        public string UserName { get; set; }
        public NewGameCommand(string userName)
        {
            UserName = userName;

        }
        public void Execute()
        {
           
            Game game = new Game();
            EngineClass.CurrentGame = game;
            var firstRoom = new Room(Guid.NewGuid());
            firstRoom.Name = "Room One";
            firstRoom.Description = "This is the default room created";

            var thePlayer = new Player(Guid.NewGuid());
            thePlayer.Name = UserName;
            thePlayer.CurrentRoom = firstRoom;

            game.AddGameObject(firstRoom);
            game.AddGameObject(thePlayer);

            game.Player = thePlayer;

            bool addingObjects = true;
            int playerCount = 1;
            int roomCount = 2;
            Console.WriteLine("Welcome {0} your game has started!", UserName);
            Console.WriteLine("________________________");

            while (addingObjects)
            {
                int index = 0;
                List<Room> rooms =new List<Room>();
                Console.WriteLine("Add objects to your game -(yes/no)");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("What will you like to add - (player/room)");
                    string typeResponse = Console.ReadLine();
                    if (typeResponse == "player")
                    {
                        var player = new Player(Guid.NewGuid());
                        Console.WriteLine("What is your player's name");
                        var playerName = Console.ReadLine();
                        player.Name = playerName;

                     

                        Console.WriteLine("Select player's room/add new room");
                        var res = Console.ReadLine();
                        if(res == "select")
                        {
                            Console.WriteLine("________________");
                            Console.WriteLine("Here are the available rooms");

                            foreach (var go in game.GameObjects)
                            {
                                index++;
                                var room = go as Room;
                                if (room != null)
                                {
                                    Console.WriteLine("{0} - {1}", index, room.Name);
                                    rooms.Add(room);
                                }



                            }
                            Console.WriteLine("Room Number?");
                            var roomNumber = int.Parse(Console.ReadLine());
                            var selectedRoom = rooms[roomNumber];
                            player.CurrentRoom = selectedRoom;


                        }else if (res == "add")
                        {
                            var newRoom = new Room(Guid.NewGuid());
                            Console.WriteLine("Room name?");
                            var roomName = Console.ReadLine();
                            newRoom.Name = roomName;
                            Console.WriteLine("__________");
                            Console.WriteLine("Room Description?");
                            var roomDescription = Console.ReadLine();
                            newRoom.Description = roomDescription;
                            game.AddGameObject(newRoom);
                            player.CurrentRoom = newRoom;

                        }
                  
                        game.AddGameObject(player);
                    }
                    else if (typeResponse == "room")
                    {
                        var additionalRoom = new Room(Guid.NewGuid());
                        Console.WriteLine("Room name?");
                        var roomName = Console.ReadLine();
                        additionalRoom.Name = roomName;
                        Console.WriteLine("__________");
                        Console.WriteLine("Room Description?");
                        var roomDescription = Console.ReadLine();
                        additionalRoom.Description = roomDescription;
                        game.AddGameObject(additionalRoom);
                    }


                }
                else
                {
                    addingObjects = false;
                }


            }

            Console.WriteLine("____________________");
            Console.WriteLine("Would you like to save game? - (yes/no) / Or Enter new room / View Inventory?");
            string saveGameResponse = Console.ReadLine();
            if (saveGameResponse == "yes")
            {
                var command = new SwitchStateCommand(new StateManager(), new SaveGameState(game));
                command.Execute();
            }else if(saveGameResponse=="new room")
            {
                Console.WriteLine("___________");
                Console.WriteLine(" You presently have the following rooms available");
                foreach(var item in game.GameObjects)
                {
                    var room = item as Room;
                    if(room != null)
                    {
                        Console.WriteLine("{0} -{1}", room.Name, room.Description);
                    }
                }
                Console.WriteLine("Pick your new room");
                var newRoom = Console.ReadLine();
                var command = new SwitchRoomCommand(game,newRoom);
                command.Execute();
            }
            else if(saveGameResponse== "inventory")
            {
                var command = new SwitchStateCommand(new StateManager(), new ViewInventaryState(game));
                command.Execute();
            }
        }
    }
}

