using System;
using System.Collections.Generic;
using System.Linq;
using TaksTwo.Models;

namespace TaskTwo.Controllers
{
    class SellController
    {
        private List<Car> cars = new List<Car>();

        public SellController() { }

        public void AddCar(Car car) {
            cars.Add(car);
        }

        public void PrintList()
        {
            cars.ForEach(c => Console.WriteLine(c.ToString()));
        }

        #region TASK 3
        public void ModelOrderByDescending()
        {
            cars = cars.OrderByDescending(c => c.Model).ToList();
        }

        public void ModelOrderByAscending()
        {
            cars = cars.OrderBy(c => c.Model).ToList();
        }

        public void PriceOrderByDescending()
        {
            cars = cars.OrderByDescending(c => c.Price).ToList();
        }

        public void PriceOrderByAscending()
        {
            cars = cars.OrderBy(c => c.Price).ToList();
        }

        #endregion TASK 3
    }
}
