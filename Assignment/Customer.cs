using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Customer
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public DateTime dateBirth { set; get; }        
        public Customer? previous { set; get; }
        public Customer? next { set; get; }

        //constructor,initialize the properties for the instance
        public Customer(string firstN, string lastN, DateTime dateB)
        {
            this.firstName = firstN;
            this.lastName = lastN;
            this.dateBirth = dateB;
            this.previous = null;
            this.next = null;
        }

        //calculate the age of the customer base on the date birth
        public int CaculateAge()
        {
            if (this.dateBirth.Year > DateTime.Now.Year)
            {
                return -1;
            }
            else 
            { 
                return DateTime.Now.Year - dateBirth.Year;
            }
        }

    }
}
