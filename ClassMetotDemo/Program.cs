using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerId = 101;
            customer1.customerName = "Bekir";
            customer1.customerSurname = "ATLI";
            customer1.customerAdress = "Keçiören/Ankara";
            Customer customer2 = new Customer();
            customer2.customerId = 102;
            customer2.customerName = "Sema";
            customer2.customerSurname = "ATLI";
            customer2.customerAdress = "Keçiören/Ankara";
            Customer customer3 = new Customer();
            customer3.customerId = 103;
            customer3.customerName = "Emir";
            customer3.customerSurname = "ACAR";
            customer3.customerAdress = "Merkez/Amasya";
            Customer customer4 = new Customer();
            customer4.customerId = 104;
            customer4.customerName = "Tuna";
            customer4.customerSurname = "AKBAŞ";
            customer4.customerAdress = "Kaman/Kırşehir";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };
            customerManager.customerList(customers);

            customerManager.Delete(customer3);
            Console.ReadKey();
        }
    }
}
