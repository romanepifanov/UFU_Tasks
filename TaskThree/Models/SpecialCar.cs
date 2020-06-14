namespace TaskThree.Models
{
    class SpecialCar : Car
    {
        public string Kind { get; set; }
        public string Weight { get; set; }
        public string OverallDimensions { get; set; }

        public SpecialCar(Car car, string kind, string weight, string overallDimensions) : base(car)
        {
            this.Kind = kind;
            this.Weight = weight;
            this.OverallDimensions = overallDimensions;
        }
    }
}
