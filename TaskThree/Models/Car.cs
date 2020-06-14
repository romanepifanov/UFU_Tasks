using System;

namespace TaksThree.Models
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

        public Car(string model, int issueYear, string price, string equipment, string producingCountry)
        {
            this.Model = model;
            this.IssueYear = issueYear;
            this.Price = price;
            this.Equipment = equipment;
            this.ProducingCountry = producingCountry;
        }

        public Car(Car car) : this(car.Model, car.IssueYear, car.Price, car.Equipment, car.ProducingCountry) { }

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
