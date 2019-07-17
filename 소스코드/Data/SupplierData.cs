using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class SupplierData
    {
        public List<Supplier> GetAll()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Suppliers.Distinct().ToList();
            }
        }

        public List<Supplier> SearchAll(int? Id)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Suppliers
                            where x.SupplierId == Id
                            select x;

                return query.ToList();
            }
        }
    }
}
