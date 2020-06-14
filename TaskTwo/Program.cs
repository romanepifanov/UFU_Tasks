using System;
using System.Text;
using TaskTwo.Models;
using TaskTwo.Controllers;

namespace TaskTwo
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SellController sellController = new SellController();
            Car car = new Car("Ford Focus II", 2007, "245 000 руб", "Хэтчбек 5 дв.", "Россия");
            Car car1 = new Car("Audi", 2011, "600 000 руб", "Хэтчбек 5 дв.", "Россия");
            Car car2 = new Car("daewoo nexia", 2011, "200 000 руб", "Хэтчбек 5 дв.", "Россия");

            sellController.SellCar(car);
            sellController.SellCar(car1);
            sellController.SellCar(car2);
            sellController.PrintList();
        }
    }
}
