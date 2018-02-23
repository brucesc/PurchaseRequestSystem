using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PRSContext db = new PRSContext();
            DateTime x = new DateTime(2018, 2, 20);

            //db.users.Add(new User("Greg", "123abc", "Greg", "Smith", null, null, true, true, true, x, x));
            //db.users.Add(new User("Cong", "123abc", "Cong", "Smith", null, null, true, false, true, x, x));
            //db.users.Add(new User("Mike", "123abc", "Mike", "Smith", null, null, true, false, true, x, x));
            //db.users.Add(new User("Chris", "123abc", "Chris", "Smith", null, null, false, true, true, x, x));
            //db.users.Add(new User("Nate", "123abc", "Nate", "Smith", null, null, false, false, true, x, x));
            //db.users.Add(new User("Bob", "123abc", "Bob", "Smith", null, null, true, false, true, x, x));
            //db.users.Add(new User("Steven", "123abc", "Steven", "Smith", null, null, true, true, true, x, x));
            //db.users.Add(new User("Jennifer", "123abc", "Jennifer", "Doe", null, null, true, false, true, x, x));
            //db.users.Add(new User("Michael", "123abc", "Michael", "Smith", null, null, true, true, true, x, x));
            //db.users.Add(new User("Christina", "123abc", "Christina", "Doe", null, null, false, false, true, x, x));


            db.vendors.Add(new Vendor("AMZN", "Amazon", "111 Main Street", "Seattle", "WA", "98101", "(888) 280-4331", "Amazon@amazon.com", true, true, x, x));
            db.vendors.Add(new Vendor("WLMT", "Walmart", "111 Main Street", "Bentonville", "AR", "72712", "(800) 925-6278", "Walmart@madeinchina.com", true, true, x, x));
            db.vendors.Add(new Vendor("TRGT", "Target", "111 Main Street", "Minneapolis", "MN", "55111", "(800) 440-0680", "Target@targetdog.com", true, true, x, x));
            db.vendors.Add(new Vendor("BSTB", "Best Buy", "111 Main Street", "Richfield", "MN", "55423", "(888) 237-8289", "WhatHappendToUs@bestbuy.com", true, true, x, x));






            db.SaveChanges();

        }
    }
}
