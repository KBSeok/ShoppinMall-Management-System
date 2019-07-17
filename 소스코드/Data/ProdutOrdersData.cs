using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiniProject.Data
{
    class ProdutOrdersData : EntityData<ProductOrder>
    {
        public void ProductOrdering(int productId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                ProductOrder productOrder = new ProductOrder();
                
                productOrder.ProductId = productId;
                productOrder.SupplierId = 2;
                productOrder.OrderDate = DateTime.Now.ToString("yy.MM.dd");
                productOrder.ShippedDate =
                    DateTime.Now.AddDays(1).ToString("yy.MM.dd");
                productOrder.Amount = 10;
                DB.ProdutOrders.Insert(productOrder);
                
            }
        }

        
    }
}
