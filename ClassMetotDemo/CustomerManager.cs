using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Yeni müşteri eklendi.\n" +"Müşteri Id :"+customer.Id+"\n"+"Müşteri Adı : "+customer.Name + "\n" + "Müşteri Soyadı : " + customer.Surname + "\n" + "Müşteri Maaşı : " + customer.Salary);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silme işlemi başarıyla gerçekleşmiştir.\n" + "Müşteri Id :" + customer.Id + "\n" + "Müşteri Adı : " + customer.Name + "\n" + "Müşteri Soyadı : " + customer.Surname + "\n" + "Müşteri Maaşı : " + customer.Salary);
        }

        public void Show(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteriler: .\n" + "Müşteri Id :" + customer.Id + "\n" + "Müşteri Adı : " + customer.Name + "\n" + "Müşteri Soyadı : " + customer.Surname + "\n" + "Müşteri Maaşı : " + customer.Salary);
            }
        }

    }
}
