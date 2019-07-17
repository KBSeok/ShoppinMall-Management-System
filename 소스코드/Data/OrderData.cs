using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject.Data
{
    class OrderData : EntityData<Order>
    {
        
        public Order GetByPK(int orderId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Orders.FirstOrDefault(x => x.OrderID == orderId);
            }
        }

        public void ProductOrder(int Amount, string ProductName, string Color, string Size, object ProductInfo)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                Random random = new Random();
                Order productOrder = new Order();
                Order_Detail productOrderDetail = new Order_Detail();
                LoginControl frm = new LoginControl();
                CustomerOrder customerOrder = new CustomerOrder();
                Product productInfo = ProductInfo as Product;

                if (productInfo == null) return;
                
                productInfo.StockAmount = productInfo.StockAmount - Amount;
                int EId = context.Employees.Select(x => x.EmployeeID).Max();
                int SId = context.Shippers.Select(x => x.ShipperID).Max();

                int EmployeeId = random.Next(1, EId);
                int ShiperId = random.Next(1, SId);

                int OId = context.Orders.Select(x => x.OrderID).ToList().Count;

                productOrder.OrderDate = DateTime.Now.ToString("yy.MM.dd");
                productOrder.ShippedDate = DateTime.Now.AddDays(5).ToString("yy.MM.dd");
                productOrder.OrderID = OId + 1;
                productOrder.ShiperID = ShiperId;
                productOrder.EmployeeID = EId;
                productOrder.CustomerName = "Choi Haesong";

                productOrderDetail.OrderID = productOrder.OrderID;
                productOrderDetail.Amount = Amount;
                productOrderDetail.ProductId =
                    context.Products.Where(x => x.ProductName == ProductName && x.Size == Size
                    && x.Color == Color).Select(x => x.ProductId).First();
                
                DB.Order.Insert(productOrder);
                DB.Orderdetail.Insert(productOrderDetail);
                DB.Product.Update(productInfo);
                
            }
        }
    }
}
