using System;
using System.Text;
using TaksOne.Models;

namespace TaksOne
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Car car = new Car("Ford Focus II", 2007, "245 000 руб", "Хэтчбек 5 дв.", "Россия");
            Console.WriteLine(car.ToString());
        }
    }
}
