using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miniproject;

namespace MiniProject.Data
{
    class CustomerData
    {
        public List<Customer> GetAll()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Customers.Distinct().ToList();
            }
        }

        public List<Customer> SearchInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                if (string.IsNullOrEmpty(Id) == true &&
                    string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Customers
                                select x;
                    return query.ToList();
                }

                else if (string.IsNullOrEmpty(Id) == true)
                {
                    var query = from x in context.Customers
                                where x.Grade == Grade
                                select x;

                    return query.ToList();
                }
                else if (string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Customers
                                where x.UserId == Id
                                select x;

                    return query.ToList();
                }
                else
                {
                    var query = from x in context.Customers
                                where x.UserId == Id && x.Grade == Grade
                                select x;
                    return query.ToList();
                }
                
            }
        }
    }
}
