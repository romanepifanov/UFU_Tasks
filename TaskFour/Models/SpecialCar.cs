namespace TaskFour.Models
{
    class SpecialCar : Car
    {
        public string Kind { get; set; }
        public string Weight { get; set; }
        public string OverallDimensions { get; set; }

        public override string ToString()
        {
            return @$"
                    Вид: {this.Kind}
                    Масса: {this.Weight}
                    Габаритные размеры: {this.OverallDimensions}
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
