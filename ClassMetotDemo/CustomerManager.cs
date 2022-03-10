using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        Customer customer = new Customer();
       
       public void Add(Customer customer) {
            Console.WriteLine(customer.customerId + " Id'li Müşteri eklendi!");
            
        }
        
        public void Delete(Customer customer)
        {
            
            Console.WriteLine(customer.customerId + "Id'li kullınıcı silindi!");

        }
        public void customerList(Customer[]customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.customerName + " Listelendi");
            }
        }
    }
}
