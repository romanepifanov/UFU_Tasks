using System;
using System.Collections.Generic;
using System.Text;
using TaskTwo.Models;

namespace TaskTwo.Models
{
    class UsedCar: Car
    {
        public string SafetyDegree { get; set;}
        public string Owner { get; set; }
        public string Mileage { get; set; }

        public UsedCar(Car car, string safetyDegree, string owner, string mileage) : base(car)
        {
            this.SafetyDegree = safetyDegree;
            this.Owner = owner;
            this.Mileage = mileage;
        }
    }
}
