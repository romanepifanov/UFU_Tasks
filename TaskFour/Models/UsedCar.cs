namespace TaskFour.Models
{
    class UsedCar : Car
    {
        public string SafetyDegree { get; set; }
        public string Owner { get; set; }
        public string Mileage { get; set; }

        public override string ToString()
        {
            return @$"
                    Состояние: {this.SafetyDegree}
                    ФИО хозяина: {this.Owner}
                    Пробег: {this.Mileage}
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
