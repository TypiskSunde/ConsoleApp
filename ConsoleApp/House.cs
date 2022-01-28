using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class House
    {
        private List<Room> _rooms { get; set; } = new List<Room>();

        private void DisplayRoomDetails(Room room)
        {
            Console.WriteLine($"Room: {room.Name}, {room.Area}");
        }

        private void DisplayRoomsDetails(List<Room> rooms)
        {
            foreach (var room in rooms)
            {
                DisplayRoomDetails(room);
            }
        }

        public void AddRoom()
        {
            Console.WriteLine("Enter your room name: ");
            string room = Console.ReadLine();
            Console.Write("Enter length of the room in feet ");
            var length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of the room in feet ");
            var width = Convert.ToInt32(Console.ReadLine());
            var area = length * width;
            Console.WriteLine("Your " + room + " is " + area + " Square feet.");
            Console.ReadLine();

            _rooms.Add(new Room(room, area));
        }

        public void SearchRoom()
        {
            Console.WriteLine("Contact number to search:");
            var area = Convert.ToInt32(Console.ReadLine());
            var room = _rooms.FirstOrDefault(c => c.Area == area);
            if (room == null)
            {
                Console.WriteLine("Kontakt ikke funnet");
            }
            else
            {
                DisplayRoomDetails(room);
            }
        }

        public void DisplayAllRoom()
        {
            DisplayRoomsDetails(_rooms);
        }

        public void DeleteRooms()
        {
            var index = 0;
            foreach (var room in _rooms)
            {
                Console.WriteLine($"{index} {room.Name}");
                index++;
            }

            Console.WriteLine("Skriv index på rom for å slette");
            index = Convert.ToInt32(Console.ReadLine());
            if (index < 0 || index >= _rooms.Count()) return;
            _rooms.RemoveAt(index);
        }
    }
}
