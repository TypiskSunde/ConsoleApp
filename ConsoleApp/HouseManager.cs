using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HouseManager
    {
        private House _house;

        public HouseManager()
        { 
            _house = new House();
            PrintCommands();
        }

        private void PrintCommands()
        {
            Console.WriteLine("");
            Console.WriteLine("############################");
            Console.WriteLine("");
            Console.WriteLine("Hello from the Console House App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Enter the name of the room ");
            Console.WriteLine("2 search");
            Console.WriteLine("3 view all rooms");
            Console.WriteLine("4 delete rooms");
            Console.WriteLine("5 sum of all rooms in square feet");
            Console.WriteLine("Press 'x' to exit");
            var userInput = Console.ReadLine();
            UserInputLoop(userInput);
        }


        private void UserInputLoop(string userInput)
        {
            switch (userInput)
            {
                case "1": _house.AddRoom(); break;
                case "2": _house.SearchRoom(); break;
                case "3": _house.DisplayAllRoom(); break;
                case "4": _house.DeleteRooms(); break;
                case "5": _house.SumAllRoomInFeet(); break;
                case "x": return;
                default: Console.WriteLine("Select valid operation"); break;
            }

            PrintCommands();
        }
    }
}
