using System;
namespace Project13InsuranceManagement.DataLayer
{
    [Serializable]
    public class Rental : ObjectPlus
    {
        public Client Client { get; private set; }
        public Car RentedCar { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }

        public Rental(Client client, Car car, DateTime fromDate, DateTime toDate)
        {
            SetClient(client);
            SetCar(car);
            FromDate = fromDate;
            ToDate = toDate;
        }

        public void SetClient(Client client)
        {
            if (Client == null)
            {
                Client = client;
                client.AddRental(this);
            }
        }

        public void SetCar(Car car)
        {
            if (RentedCar == null)
            {
                RentedCar = car;
                car.AddRental(this);
            }
        }

        public override string ToString()
        {
            return Client.FirstName + " " + Client.LastName + " " + RentedCar.Brand + " " + RentedCar.Model;
        }
    }
}