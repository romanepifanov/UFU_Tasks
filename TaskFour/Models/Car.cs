using System;

namespace TaskFour.Models
{
    class Car
    {
        public string Model { get; set; }
        public int IssueYear { get; set; }
        public string Price { get; set; }
        public string Equipment { get; set; }
        public string ProducingCountry { get; set; }
        public DateTime? SaleDate { get; set; }
        public string Buyer { get; set; }

        public Car(string model, int issueYear, string price, string equipment, string producingCountry, string buyer)
        {
            this.Model = model;
            this.IssueYear = issueYear;
            this.Price = price;
            this.Equipment = equipment;
            this.ProducingCountry = producingCountry;
            this.SaleDate = DateTime.Now;
            this.Buyer = buyer;
        }

        public Car(Car car) : this(car.Model, car.IssueYear, car.Price, car.Equipment, car.ProducingCountry, car.Buyer) { }

        public override string ToString()
        {
            return @$"
                    Марка автомобиля: {this.Model}
                    Год выпуска: {this.IssueYear}
                    Цена автомобиля: {this.Price}
                    Комплектация: {this.Equipment}
                    Страна производитель: {this.ProducingCountry}
                    Дата продажи: {this.SaleDate.ToString()}
                    ФИО покупателя: {this.Buyer}
                    ";
        }
    }
}
