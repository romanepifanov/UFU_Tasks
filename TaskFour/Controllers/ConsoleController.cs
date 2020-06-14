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

                sellController.SellCar(new Car(items[0], Int32.Parse(items[1]), items[2], items[3], items[4], items[5]));
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
// Exemples :
//Ford Focus II, 2007, 245000 руб, Хэтчбек 5 дв., Россия, Епифанов Роман Дмитриевич
//Audi, 2011, 600000 руб, Хэтчбек 5 дв., Россия, Епифанов Роман Дмитриевич
//Daewoo nexia, 2011, 200000 руб, Хэтчбек 5 дв., Россия, Епифанов Роман Дмитриевич

