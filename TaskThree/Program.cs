using System;
using System.Text;
using TaksThree.Controllers;
using TaksThree.Models;

namespace TaskThree
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SellController sellController = new SellController();

            sellController.SellCar(new Car("Ford Focus II", 2007, "245 000 руб", "Хэтчбек 5 дв.", "Россия"));
            sellController.SellCar(new Car("Audi", 2011, "600 000 руб", "Хэтчбек 5 дв.", "Россия"));
            sellController.SellCar(new Car("Daewoo nexia", 2011, "200 000 руб", "Хэтчбек 5 дв.", "Россия"));
            sellController.PrintList();

            Console.WriteLine("--------------------------------"); 
            sellController.ModelOrderByAscending();
            sellController.PrintList();

            Console.WriteLine("--------------------------------");
            sellController.ModelOrderByDescending();
            sellController.PrintList();

            Console.WriteLine("--------------------------------");
            sellController.PriceOrderByAscending();
            sellController.PrintList();

            Console.WriteLine("--------------------------------");
            sellController.PriceOrderByDescending();
            sellController.PrintList();
        }
    }
}
