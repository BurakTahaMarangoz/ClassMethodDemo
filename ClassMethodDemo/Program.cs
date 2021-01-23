using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 001;
            customer1.Name = "Burak";
            customer1.BankNumber = 33432;
            customer1.CallNumber = "0 111 111 1111 ";

            Customer customer2 = new Customer();
            customer2.Id = 002;
            customer2.Name = "James";
            customer2.BankNumber = 33789;
            customer2.CallNumber = "0 222 222 2222 ";

            Customer customer3 = new Customer();
            customer3.Id = 003;
            customer3.Name = "Holmes";
            customer3.BankNumber = 33112;
            customer3.CallNumber = "0 333 333 3333 ";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };



            CustomerManager customerManager = new CustomerManager();


            Console.WriteLine("---------------Banka Yönetim Sistemi------------");

            Console.WriteLine("1-->Müşteri Ekleme");
            Console.WriteLine("2-->Müşteri Silme");
            Console.WriteLine("3-->Müşterileri Listele");

            Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    customerManager.CustomerAdd(customer1);
                    break;

                case "2":
                    customerManager.CustomerDel(customer2);
                    break;

                case "3":
                    customerManager.CustomerList(customers); // 
                    break;
            }







        }
    }
}
