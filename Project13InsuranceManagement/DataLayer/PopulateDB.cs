using Project13InsuranceManagement.IdentityManagement;
using System;

namespace Project13InsuranceManagement.DataLayer
{
    public static class PopulateDB
    {
        public static void Populate()
        {
            Car car1 = new Car("Porsche", "Cayman", 300.00);
            Car car2 = new Car("Audi", "A6", 125.00);
            Car car3 = new Car("Fiat", "500", 65.00);
            User user1 = new User("Konrad Budny", "Jasło");
            User user2 = new User("Bonifacy Kowalski", "Bogucin");
            Client client1 = new Client("Mirosława", "Kowalska", 5, 64071409295);
            Rental rental1 = new Rental(client1, car2, new DateTime(2018, 1, 3), new DateTime(2018, 2, 1));
        }
    }
}