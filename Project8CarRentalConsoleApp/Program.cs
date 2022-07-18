using System;
using System.Collections.Generic;
/*
 * There are 2 relationships between classes Renter, Rental and Car
 * 1) Renter - Rental relationship, which is one-to-many relatioship, since a renter can rent multiple times and a rent is assigned to one renter only
 * 2) Rental - Car relationship,which is one-to-many relationship, since a rental include one car, but a car can be rented multiple times(the car can be found in multiple rentals that does not overlap in time)
 * There are 2 more relationship types(Not shown in this project): one-to-one and many-to-many
 * 
 *    
 */
namespace Project8RelationshipClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renter p = new Renter { FirstName = "Bozydar", LastName = "Bystry", BirthDate = new DateTime(1956, 7, 12), Discount = 15 };
            Renter p2 = new Renter { FirstName = "Janusz", LastName = "Klin", BirthDate = new DateTime(1981, 4, 1), Discount = 20 };
            Rental r1 = new Rental { StartDate = new DateTime(2006, 7, 12), EndDate = new DateTime(2007, 7, 12) };
            Car c = new Car { Make = "Nissan", Model = "Maxima", VIN = "N982FJEKWJ3JA92HHCJ2", PricePerDay = 113.89 };
            Car c2 = new Car { Make = "Audi", Model = "A8", VIN = "VW2B85G4HSIHI34BNKJBFDE3", PricePerDay = 125.67 };
            p.AddRental(r1);
            c.AddCarToRental(r1);
            Console.WriteLine(String.Join(" ",c.CarRentals));
            r1.SetRenter(p2);
            r1.SetCar(c2);
            Console.WriteLine("Renter " + r1.Renter);
            Console.WriteLine(p2.Rentals.Count);
            Console.WriteLine("Car "+r1.Car);
            Console.WriteLine(p2.Rentals.Count);
            Console.ReadKey();
        }
    }
}
public class Renter
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Discount { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Rental> Rentals { get; } = new List<Rental>();
    public void AddRental(Rental rental)
    {
        if (!Rentals.Contains(rental))
        {
            Rentals.Add(rental);
            rental.SetRenter(this);
        }
    }
    public void RemoveRental(Rental rental)
    {
        if (Rentals.Contains(rental))
        {
            Rentals.Remove(rental);
            rental.RemoveRenter(this);
        }
    }
    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Discount + " " + BirthDate;
    }
}

public class Rental
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DiscountAtTheTimeOfRent { get; }
    public double TotalPrice
    {
        get
        {
            return (EndDate - StartDate).TotalDays * (100 - DiscountAtTheTimeOfRent) / 100 * Car.PricePerDay;
        }
    }
    public Renter Renter { get; private set; }
    public Car Car { get; set; }
    public Rental(Car car, Renter renter)
    {
        SetCar(car);
        SetRenter(renter);
    }
    public Rental() { }
    public void SetRenter(Renter renter)
    {
        if (Renter != null && Renter != renter)
        {
            RemoveRenter(Renter);
        }
        if (Renter == null)
        {
            Renter = renter;
            Renter.AddRental(this);
        }
    }
    public void RemoveRenter(Renter renter)
    {
        if (Renter != null)
        {
            Renter temp = renter;
            Renter = null;
            temp.RemoveRental(this);
        }
    }
    public void SetCar(Car car)
    {
        if (Car != null && Car != car)
        {
            RemoveCar(Car);
        }
        if (Car == null)
        {
            Car = car;
            Car.AddCarToRental(this);
        }
    }
    public void RemoveCar(Car car)
    {
        if (Car != null)
        {
            Car temp = car;
            Car = null;
            temp.RemoveRental(this);
        }
    }
}
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public double PricePerDay { get; set; }
    public string VIN { get; set; }
    public List<Rental> CarRentals { get; } = new List<Rental>();
    public void AddCarToRental(Rental rental)
    {
        if (!CarRentals.Contains(rental))
        {
            CarRentals.Add(rental);
            rental.SetCar(this);
        }
    }
    public void RemoveRental(Rental rental)
    {
        if (CarRentals.Contains(rental))
        {
            CarRentals.Remove(rental);
            rental.RemoveCar(this);
        }
    }
    public override string ToString()
    {
        return Make + " " + Model + " " + PricePerDay + " " + VIN;
    }
}