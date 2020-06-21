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
            Car car = new Car()
            {
                Model = "Ford Focus II",
                IssueYear = 2007,
                Price = "245 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            };
            Car car1 = new SportCar()
            {
                Seconds = "5",
                EngineDisplacement = "5 литров",
                Power = "200 лошадиных сил",
                Model = "Ford Focus II",
                IssueYear = 2007,
                Price = "245 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            };
            Car car2 = new UsedCar()
            {
                SafetyDegree = "Не битая",
                Owner = "Петров Петр Петрович",
                Mileage = "100 000 км",
                Model = "Ford Focus II",
                IssueYear = 2007,
                Price = "245 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            };

            sellController.SellCar(car);
            sellController.SellCar(car1);
            sellController.SellCar(car2);
            sellController.PrintList();
        }
    }
}
