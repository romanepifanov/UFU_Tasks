using System;
using System.Text;
using TaskThree.Controllers;
using TaskThree.Models;

namespace TaskThree
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SellController sellController = new SellController();
            sellController.SellCar(new Car()
            {   Строительная, 13 600 кг, 2830.0 мм/7620.0 мм/2590.0 мм, Гусеничный экскаватор Cat 313D2 L, 2018, 5 000 000 руб, Удлиненная стрела, США, 06/26/2020, Иванов Иван Иванович
                Model = "Ford Focus II",
                IssueYear = 2008,
                Price = "275 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            });
            sellController.SellCar(new SportCar()
            {
                Seconds = "5",
                EngineDisplacement = "5 литров",
                Power = "200 лошадиных сил",
                Model = "Ford Focus III",
                IssueYear = 2007,
                Price = "245 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            });
            sellController.SellCar(new UsedCar()
            {
                SafetyDegree = "Не битая",
                Owner = "Петров Петр Петрович",
                Mileage = "100 000 км",
                Model = "Ford Focus I",
                IssueYear = 2009,
                Price = "300 000 руб",
                Equipment = "Хэтчбек 5 дв.",
                ProducingCountry = "Россия",
                SaleDate = DateTime.Now,
                Buyer = "Иванов Иван Иванович"
            });

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
