using System;
using System.Text;
using TaksTwo.Models;
using TaskTwo.Controllers;

namespace TaskTwo
{
    class Program
    {
        static void Main()
        {
            ConsoleController consoleController = new ConsoleController();

            consoleController.Init();
            //SellController sellController = new SellController();
            //Car car = new Car("Ford Focus II", 2007, "245 000 руб", "Хэтчбек 5 дв.", "Россия");
            //Car car1 = new Car("Audi", 2011, "600 000 руб", "Хэтчбек 5 дв.", "Россия");
            //Car car2 = new Car("daewoo nexia", 2011, "200 000 руб", "Хэтчбек 5 дв.", "Россия");


            //sellController.AddCar(car);
            //sellController.AddCar(car1);
            //sellController.AddCar(car2);
            //sellController.PrintList();

            //#region TASK 3
            //Console.WriteLine("_________________________");
            //sellController.ModelOrderByAscending();
            //sellController.PrintList();

            //Console.WriteLine("_________________________");
            //sellController.ModelOrderByDescending();
            //sellController.PrintList();

            //Console.WriteLine("_________________________");
            //sellController.PriceOrderByAscending();
            //sellController.PrintList();

            //Console.WriteLine("_________________________");
            //sellController.PriceOrderByDescending();
            //sellController.PrintList();
            //#endregion TASK 3
        }
    }
}
