using System;
using System.Collections.Generic;
using System.Linq;

namespace Project13InsuranceManagement.DataLayer
{
    [Serializable]
    public class Car : ObjectPlus
    {
        public String Brand { get; set; }
        public String Model { get; set; }
        public double Price { get; set; }
        public List<Rental> Rentals { get; private set; } = new List<Rental>();

        public Car(String brand, String model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public void AddRental(Rental rental)
        {
            if (!Rentals.Contains(rental))
            {
                Rentals.Add(rental);
                rental.SetCar(this);
            }
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }

        public bool IsAvailable(DateTime from, DateTime to)
        {
            return Rentals.Where(r => from <= r.ToDate && to >= r.FromDate).Count() == 0;
        }

        public static List<Car> GetAvailableCars(DateTime from, DateTime to)
        {
            return ObjectPlus.Objects[typeof(Car)].Cast<Car>().Where(c => c.IsAvailable(from, to)).ToList();
        }
    }
}