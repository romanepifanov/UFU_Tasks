using System;
using System.Collections.Generic;
using TaskTwo.Models;

namespace TaskTwo.Controllers
{
    class SellController
    {
        private readonly List<Car> cars = new List<Car>();

        public SellController() { }

        public void SellCar(Car car) {
            cars.Add(car);
        }

        public void PrintList()
        {
            cars.ForEach(c => Console.WriteLine(c.ToString()));
        }
    }
}
