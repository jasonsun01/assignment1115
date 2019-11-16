using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           // initialize the customer data
            Customer customer1 = new Customer("Jack1", "Smith1", Convert.ToDateTime("1991-8-1"));
            Customer customer2 = new Customer("Jack2", "Smith2", Convert.ToDateTime("1992-8-1"));
            Customer customer3 = new Customer("Jack3", "Smith3", Convert.ToDateTime("1993-8-1"));
            Customer customer4 = new Customer("Jack4", "Smith4", Convert.ToDateTime("1994-8-1"));
            Customer customer5 = new Customer("Jack5", "Smith5", Convert.ToDateTime("1995-8-1"));
            Customer customer6 = new Customer("Jack6", "Smith6", Convert.ToDateTime("1996-8-1"));
            //create customer string
            CustomerString customerString = new CustomerString();
            CustomerString.AddCustomerToString(customerString, customer1);
            CustomerString.AddCustomerToString(customerString, customer2);
            CustomerString.AddCustomerToString(customerString, customer3);
            CustomerString.AddCustomerToString(customerString, customer4);
            CustomerString.AddCustomerToString(customerString, customer5);
            CustomerString.AddCustomerToString(customerString, customer6);
            Customer currentCustomer = customerString.firstCustomer;

            // output the customer data as ascend order
            while (currentCustomer != null) 
            {
                Console.WriteLine("Customer information: First Name:{0}, Last Name:{1}, age:{2}", 
                    currentCustomer.firstName,currentCustomer.lastName,currentCustomer.CaculateAge().ToString());
                currentCustomer = currentCustomer.next;
            }
            Console.WriteLine("------------------------------------------------------------------");
            Customer currentCustomer1 = CustomerString.FindCustomerStringEnd(customerString.firstCustomer);

            // output the customer data as descend order
            while (currentCustomer1!=null)
            {
                Console.WriteLine("Customer information: First Name:{0}, Last Name:{1}, age:{2}",
                   currentCustomer1.firstName, currentCustomer1.lastName, currentCustomer1.CaculateAge().ToString());
                currentCustomer1 = currentCustomer1.previous;
            }

        }
    }
}
