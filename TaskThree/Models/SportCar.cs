namespace TaskThree.Models
{
    class SportCar: Car
    {
        public string Seconds { get; set;}
        public string EngineDisplacement { get; set; }
        public string Power { get; set; }

        public SportCar(Car car, string seconds, string engineDisplacement, string power) : base(car)
        {
            this.Seconds = seconds;
            this.EngineDisplacement = engineDisplacement;
            this.Power = power;
        }
    }
}
