using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Gizem";
            customer1.Surname = "Ünal";
            customer1.Salary = 6000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "İrem İz";
            customer2.Surname = "Akdeniz";
            customer2.Salary = 7000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "İrem";
            customer3.Surname = "Önal";
            customer3.Salary = 4000;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Betül";
            customer4.Surname = "Vural";
            customer4.Salary = 7000;

            
            Customer[] customers = new Customer[] { customer1,customer2,customer3,customer4};
            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Show(customers);
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.Delete(customer4);
            customerManager.Delete(customer2);
            
        }
    }
}
