using System;
using System.Text;
using TaskFour.Models;

namespace TaskFour.Controllers
{
    public class ConsoleController
    {
        private string command = String.Empty;
        private SellController sellController = new SellController();

        public ConsoleController() { }

        public void Init()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();
            this.ShowMenu();
        }

        #region MENU METHODS
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Главное Меню");
            Console.WriteLine("->> Продать автомобиль");
            Console.WriteLine("->> Продать спортивный автомобиль");
            Console.WriteLine("->> Продать поддержанный автомобиль");
            Console.WriteLine("->> Продать специальный автомобиль");
            Console.WriteLine("->> Показать проданные автомобили");
            Console.WriteLine("->> Отсортирвовать по моделе А-Я");
            Console.WriteLine("->> Отсортирвовать по моделе Я-А");
            Console.WriteLine("->> Отсортирвовать по цене А-Я");
            Console.WriteLine("->> Отсортирвовать по цене Я-А");
            Console.WriteLine("->> Помощь");
            Console.ForegroundColor = ConsoleColor.White;
            CheckCommand();
        }
        private void ShowHelpMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Команды вводятся точно как указано в меню");
            this.ShowMenu();
        }
        private void PrintCarsMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            sellController.PrintList();
            this.ShowMenu();
        }
        private void PrintModelOrderByAscending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            sellController.ModelOrderByAscending();
            this.ShowMenu();
        }
        private void PrintModelOrderByDescending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            sellController.ModelOrderByDescending();
            this.ShowMenu();
        }
        private void PrintPriceOrderByAscending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            sellController.PriceOrderByAscending();
            this.ShowMenu();
        }
        private void PrintPriceOrderByDescending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            sellController.PriceOrderByDescending();
            this.ShowMenu();
        }
        private void AddCar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите данные через запятую пример: марка, год производства, цена, описание, страна производства, ФИО покапутеля");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                Car сar = new Car()
                {
                    Model = items[0],
                    IssueYear = Int32.Parse(items[1]),
                    Price = items[2],
                    Equipment = items[3],
                    ProducingCountry = items[4],
                    SaleDate = DateTime.Parse(items[5]),
                    Buyer = items[6],
                };

                sellController.SellCar(сar);
                Console.WriteLine("Автомобиль добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddSportCar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите данные через запятую пример: Разгон до 100 км/час, Объем двигателя, Мощность, марка, год производства, цена, описание, страна производства, ФИО покапутеля");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                SportCar сar = new SportCar()
                {
                    Seconds = items[0],
                    EngineDisplacement = items[1],
                    Power = items[2],
                    Model = items[3],
                    IssueYear = Int32.Parse(items[4]),
                    Price = items[5],
                    Equipment = items[6],
                    ProducingCountry = items[7],
                    SaleDate = DateTime.Parse(items[8]),
                    Buyer = items[9],
                };

                sellController.SellCar(сar);
                Console.WriteLine("Автомобиль добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddUsedCar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите данные через запятую пример: Состояние, ФИО хозяина, Пробег, марка, год производства, цена, описание, страна производства, ФИО покапутеля");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                UsedCar сar = new UsedCar()
                {
                    SafetyDegree = items[0],
                    Owner = items[1],
                    Mileage = items[2],
                    Model = items[3],
                    IssueYear = Int32.Parse(items[4]),
                    Price = items[5],
                    Equipment = items[6],
                    ProducingCountry = items[7],
                    SaleDate = DateTime.Parse(items[8]),
                    Buyer = items[9],
                };

                sellController.SellCar(сar);
                Console.WriteLine("Автомобиль добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddSpecialCar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите данные через запятую пример: Вид, Масса, Габаритные размеры, марка, год производства, цена, описание, страна производства, ФИО покапутеля");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                SpecialCar сar = new SpecialCar()
                {
                    Kind = items[0],
                    Weight = items[1],
                    OverallDimensions = items[2],
                    Model = items[3],
                    IssueYear = Int32.Parse(items[4]),
                    Price = items[5],
                    Equipment = items[6],
                    ProducingCountry = items[7],
                    SaleDate = DateTime.Parse(items[8]),
                    Buyer = items[9],
                };

                sellController.SellCar(сar);
                Console.WriteLine("Автомобиль добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        #endregion COMMON METHODS
        #region COMMON METHODS
        public void CheckCommand()
        {
            this.command = this.ReadLineUTF();

            switch (this.command)
            {
                case "Продать автомобиль": this.AddCar(); break;
                case "Продать спортивный автомобиль": this.AddSportCar(); break;
                case "Продать поддержанный автомобиль": this.AddUsedCar(); break;
                case "Продать специальный автомобиль": this.AddSpecialCar(); break;
                case "Показать проданные автомобили": this.PrintCarsMessage(); break;
                case "Отсортирвовать по моделе А-Я": this.PrintModelOrderByAscending(); break;
                case "Отсортирвовать по моделе Я-А": this.PrintModelOrderByDescending(); break;
                case "Отсортирвовать по цене А-Я": this.PrintPriceOrderByAscending(); break;
                case "Отсортирвовать по цене Я-А": this.PrintPriceOrderByDescending(); break;
                case "Помощь": this.ShowHelpMessage(); break;
                default: Console.WriteLine("Не верная команда"); break;
            }

            this.ShowMenu();
        }
        private string ReadLineUTF()
        {
            ConsoleKeyInfo currentKey;

            var sBuilder = new StringBuilder();
            do
            {
                currentKey = Console.ReadKey();
                // avoid capturing newline
                if (currentKey.Key != ConsoleKey.Enter)
                    sBuilder.Append(currentKey.KeyChar);

            }
            // check if Enter was pressed
            while (currentKey.Key != ConsoleKey.Enter);

            // move on the next line
            Console.WriteLine();

            return sBuilder.ToString();
        }
        #endregion COMMON METHODS
    }
}

