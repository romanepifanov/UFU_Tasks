using System;

namespace TaskTwo.Models
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
