using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class CustomerString
    {
        int lenth { set; get; }
        public Customer? firstCustomer;
        public CustomerString() 
        {
            this.lenth = 0;
            firstCustomer = null;
        }

       // compose the customer string
        public static void AddCustomerToString(CustomerString customerString,Customer customer)
        {
            if (customerString.lenth != 0)
            {

                customer.previous = FindCustomerStringEnd(customerString.firstCustomer);
                customer.previous.next = customer;
                customerString.lenth++;
            }
            else
            {
                customerString.firstCustomer = customer;
                customerString.lenth++;
            }
            
        }

        // get the last customer of the customer string 
        public static Customer FindCustomerStringEnd(Customer customer) 
        {
            if (customer.next!=null) return FindCustomerStringEnd(customer.next);
            else return customer;
            
        }
    }
}
