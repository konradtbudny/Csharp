using System;
using System.Collections.Generic;
using System.Linq;
/*
 * There are 2 relationships between classes Renter, Rental and Car
 * 1) Renter - Rental relationship, which is one-to-many relatioship, since a renter can rent multiple times and a rent is assigned to one renter only
 * 2) Rental - Car relationship,which is one-to-many relationship, since a rental include one car, but a car can be rented multiple times(the car can be found in multiple rentals that does not overlap in time)
 * 
 * There is a many-to-many relationship between classes Member and Group, since a member can associate to many groups, and a group may have many members
 * 
 * There is one-to-one relatioship(not shown up here)
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
            Console.WriteLine("-----------------------------------------------------");
            Member m1 = new Member { Name = "Bozydar", LastName = "Bystry", BirthDate = new DateTime(1956, 7, 12) };
            Member m2 = new Member { Name = "Janusz", LastName = "Klin", BirthDate = new DateTime(1981, 4, 1) };
            Group g1 = new Group { NameOfGroup = "C3", TypeOfOrganisation = "automobile" };
            Group g2 = new Group { NameOfGroup = "X5", TypeOfOrganisation = "cars" };
            g1.AddMember(m1);
            g1.AddMember(m1);
            g1.AddMember(m2);
            g2.AddMember(m2);
            g1.SetBoss(m2);
            Console.WriteLine(m2);
            Console.WriteLine("-----------------------");
            Console.WriteLine(g1);
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
public class Group
{
    public string NameOfGroup { get; set; }
    public string TypeOfOrganisation { get; set; }
    public List<Member> Members { get; } = new List<Member>();
    public Member Boss { get; private set; }
    public void AddMember(Member member)
    {
        if (!Members.Contains(member))
        {
            Members.Add(member);
            member.AddGroup(this);
        }
    }
    public void RemoveMember(Member member)
    {
        if (Members.Contains(member))
        {
            Members.Remove(member);
            member.RemoveGroup(this);
        }
    }
    public void SetBoss(Member member)
    {
        if (Boss == null && IsMember(member))
        {
            Boss = member;
            member.SetBossGroup(this);
        }
    }
    public bool IsMember(Member member)
    {
        return Members.Contains(member);
    }
    public override string ToString()
    {
        String result = NameOfGroup + " " + TypeOfOrganisation + "\nList of Members:";
        if (!Members.Any())
        {
            result += "No members";
        }
        foreach (Member member in Members)
        {
            result+="\n"+member.ToStringSimple();
        }
        return result;
    }
    public string ToStringSimple()
    {
        string result = NameOfGroup + " " + TypeOfOrganisation;
        return result;
    }

}
public class Member
{
    public string Name { get; set; }
    public String LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Group> Groups { get; } = new List<Group>();
    public Group BossedGroup { get; private set; }
    public void AddGroup(Group group)
    {
        if (!Groups.Contains(group))
        {
            Groups.Add(group);
            group.AddMember(this);
        }
    }
    public void RemoveGroup(Group group)
    {
        if (Groups.Contains(group))
        {
            Groups.Remove(group);
            group.RemoveMember(this);
        }
    }
    internal void SetBossGroup(Group group)
    {
        if (BossedGroup == null)
        {
            BossedGroup = group;
            group.SetBoss(this);
        }
    }
    public override string ToString()
    {
        string result = Name + " " + LastName + " " + BirthDate + "\nPerson is a member of:";
        if (Groups.Any())
        {
            result += " 0 groups";
        }
        foreach(Group group in Groups)
        {
            result+="\n"+group.ToStringSimple();
        }
        result += BossedGroup == null ? "\nPerson is not a boss of any group" : "\nPerson is a boss of: " + BossedGroup.ToStringSimple();
        return result;
    }
    public string ToStringSimple()
    {
        string result = Name + " " + LastName + " " + BirthDate;
        return result;
    }

}