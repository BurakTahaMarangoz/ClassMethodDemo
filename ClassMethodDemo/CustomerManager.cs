using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri Kimliği : " + customer.Id);
            Console.WriteLine("İsim :" + customer.Name);
            Console.WriteLine("Banka Numarası : " + customer.BankNumber);
            Console.WriteLine("Telefon Numarası :" + customer.CallNumber);
            Console.WriteLine("Müsteri Sisteme Başarıyla Eklendi");
            Console.ReadLine();
        }

        public void CustomerDel(Customer customer)
        {
            Console.WriteLine("Müşteri Kimliği : " + customer.Id);
            Console.WriteLine("İsim :" + customer.Name);
            Console.WriteLine("Banka Numarası : " + customer.BankNumber);
            Console.WriteLine("Telefon Numarası :" + customer.CallNumber);
            Console.WriteLine("Müsteri Sistemden Başarıyla Silindi");
            Console.ReadLine();
        }

        public void CustomerList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Müşteri Kimliği : " + customer.Id);
                Console.WriteLine("İsim :" + customer.Name);
                Console.WriteLine("Banka Numarası : " + customer.BankNumber);
                Console.WriteLine("Telefon Numarası :" + customer.CallNumber);
                Console.WriteLine("---------------------------------------------");
                Console.ReadLine();
            }
        }
    }
}
