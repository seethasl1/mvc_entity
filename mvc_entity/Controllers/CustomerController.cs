using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_entity.Models;
using mvc_entity.ViewModel;
using mvc_entity.Dataaccess;
namespace mvc_entity.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer
        //custom exception
        
        public ActionResult Index1()
        {
            throw new Exception("Something Wrong");

        }
        public ActionResult Index2()
        {
            throw new Exception("Exception for Index2");
        }

        //404 error- Not found
        public ActionResult Notfound()
        {
            return View();
        }

        public ActionResult Index()
        {
            customerdal dal= new customerdal();
            return View(dal.customers.ToList());
        }
        //overload Methods/Actions
        public ActionResult GetCustomer()
        {
            return Content("Customer with overoload Methods");
        }
        [ActionName("Getcustcode")]
        public ActionResult GetCustomer(string custcode)
        {

            return Content("Customer with code");
        }
        
        public ActionResult Load()
        {
            Customer cust1 = new Customer();

            return View("DisplayCustomer", cust1);
        }
        public ActionResult EnterData()
        {
            //viewmodel object
            vmcust_order vmobj = new vmcust_order();
            //single object is fresh
            vmobj.cust = new Customer();
            //dal is filled the customers collection
            customerdal dal= new customerdal();
            List<Customer> custscollection = dal.customers.ToList<Customer>();
            vmobj.customers = custscollection;
            return View("EnterData",vmobj);
        }
        public ActionResult submit(Customer cust)
        {
            vmcust_order vmcust = new vmcust_order(); 
            Customer obj = new Customer();
            obj.custid = Convert.ToInt32(Request.Form["cust.custid"]);
            obj.custname = Request.Form["cust.custname"];

            if (ModelState.IsValid)
            {
                //insert th customer object to database
                customerdal Dal = new customerdal();
                //added customer object to the collection
                Dal.customers.Add(cust);//in memory updation
                //then savechanges//physical commit
                Dal.SaveChanges();
                vmcust.cust = new Customer();
            }
            else
            {
                vmcust.cust = obj;
            }
            customerdal dal = new customerdal();
            List<Customer> custscollection = dal.customers.ToList<Customer>();
            vmcust.customers = custscollection;
            return View("EnterData", vmcust);
            }
            
        
        public ActionResult getview()
        {
            return View("GetData");
        }
        public ActionResult newview()
        {
            Customer c1 = new Customer();

            cust_order csorder = new cust_order();
           vmcust_order vm1 = new vmcust_order(c1,csorder);
            try
            {
            //    vm1.cust.custid=c1.custid;
            //vm1.cust.custname=c1.custname;
            //vm1.order.orderName = csorder.orderName;
            
                if (vm1 != null)
                {
                    //vm1.cust.custid = Request.Form["custid"];
                    vm1.cust.custname = Request.Form["custname"];
                    vm1.order.orderName = Request.Form["orderName"];

                    vm1.date = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            
            
            return View("NewView",vm1);
        }

    }
}