namespace TaskFour.Models
{
    class SportCar : Car
    {
        public string Seconds { get; set; }
        public string EngineDisplacement { get; set; }
        public string Power { get; set; }

        public override string ToString()
        {
            return @$"
                    Разгон до 100 км/час: {this.Seconds}
                    Объем двигателя: {this.EngineDisplacement}
                    Мощность: {this.Power}
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
