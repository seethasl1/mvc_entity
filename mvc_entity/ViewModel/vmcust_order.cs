using mvc_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_entity.ViewModel
{
    public class vmcust_order
    {
        public Customer cust { get; set; }
        public cust_order order { get; set; }

        public List<Customer> customers { get; set; }
        public vmcust_order()
        {

        }
        public vmcust_order(Customer c,cust_order co)
        {
            this.cust = cust;
            this.order = co;
        }
        public DateTime date { get; set; }

    }
}