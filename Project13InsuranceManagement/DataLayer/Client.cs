using System;
using System.Collections.Generic;

namespace Project13InsuranceManagement.DataLayer
{
    [Serializable]
    public class Client : ObjectPlus
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Discount { get; set; }
        public double Pesel { get; set; }
        public List<Rental> Rentals { get; private set; } = new List<Rental>();

        public Client(string firstName, string lastName, double discount, double pesel)
        {
            FirstName = firstName;
            LastName = lastName;
            Discount = discount;
            Pesel = pesel;
        }

        public void AddRental(Rental rental)
        {
            if (!Rentals.Contains(rental))
            {
                Rentals.Add(rental);
                rental.SetClient(this);
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}