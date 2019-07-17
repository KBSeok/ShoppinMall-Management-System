using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject.Data
{
    class OrderDetailData : EntityData<Order_Detail>
    {
        public List<Order_Detail> SearchProductInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {

                if (string.IsNullOrEmpty(Id) == true &&
                    string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Order_Details
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.ProductName = x.productname;
                        
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }

                else if (string.IsNullOrEmpty(Id) == true)
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.Grade == Grade
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.ProductName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);


                }
                else if (string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.UserId == Id
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.ProductName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }
                else
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.UserId == Id &&
                                x.Order.Customer.Grade == Grade
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.ProductName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }
            }
        }

        public List<Order_Detail> SearchOrderInfo(string orderId, string cusId)
        {
            
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                if (string.IsNullOrEmpty(orderId) == false && string.IsNullOrEmpty(cusId) == false)
                {
                    int OId = int.Parse(orderId);

                    var query = from x in context.Order_Details
                                where x.Order.OrderID == OId && x.Order.Customer.UserId == cusId
                                select new
                                {
                                    orderdetail = x,
                                    productname = x.Product.ProductName,
                                    color = x.Product.Color,
                                    size = x.Product.Size
                                };

                    var list = query.ToList();

                    foreach(var item in list)
                    {
                        item.orderdetail.ProductName = item.productname;
                        item.orderdetail.Size = item.size;
                        item.orderdetail.Color = item.color;
                    }
                    return list.ConvertAll(x => x.orderdetail);
                }

                else if(string.IsNullOrEmpty(orderId) == false && string.IsNullOrEmpty(cusId) == true)
                {
                    int OId = int.Parse(orderId);

                    var query = from x in context.Order_Details
                                where x.Order.OrderID == OId 
                                select new
                                {
                                    orderdetail = x,
                                    productname = x.Product.ProductName,
                                    color = x.Product.Color,
                                    size = x.Product.Size
                                };

                    var list = query.ToList();

                    foreach (var item in list)
                    {
                        item.orderdetail.ProductName = item.productname;
                        item.orderdetail.Size = item.size;
                        item.orderdetail.Color = item.color;
                    }
                    return list.ConvertAll(x => x.orderdetail);
                }

                else if (string.IsNullOrEmpty(cusId) == false && string.IsNullOrEmpty(orderId) == true)
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.UserId == cusId
                                select new
                                {
                                    orderdetail = x,
                                    productname = x.Product.ProductName,
                                    color = x.Product.Color,
                                    size = x.Product.Size
                                };

                    var list = query.ToList();

                    foreach (var item in list)
                    {
                        item.orderdetail.ProductName = item.productname;
                        item.orderdetail.Size = item.size;
                        item.orderdetail.Color = item.color;
                    }
                    return list.ConvertAll(x => x.orderdetail);
                }

                else
                {
                    var query = from x in context.Order_Details
                                select new
                                {
                                    orderdetail = x,
                                    productname = x.Product.ProductName,
                                    color = x.Product.Color,
                                    size = x.Product.Size
                                };

                    var list = query.ToList();

                    foreach (var item in list)
                    {
                        item.orderdetail.ProductName = item.productname;
                        item.orderdetail.Size = item.size;
                        item.orderdetail.Color = item.color;
                    }
                    return list.ConvertAll(x => x.orderdetail);
                }
            }
        }

        public List<Order_Detail> GetSize(string size)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Order_Details select x;


                if (size.Contains(size))
                    query = query.Where(x => x.Product.Size == size);

                List<Order_Detail> orders = query.ToList();


                return orders;

            }
        }

        public List<Order_Detail> SearchCusProductInfo(string customerName)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Order_Details
                            where x.Order.CustomerName == customerName
                            select new
                            {
                                order_detail = x,
                                
                                orderdate = x.Order.OrderDate,
                                parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                productname = x.Product.ProductName,
                                size = x.Product.Size,
                                color = x.Product.Color,
                                

                            };

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.order_detail.OrderDate = x.orderdate;
                    x.order_detail.ParentsCategoryName = x.parentscategotyname;
                    x.order_detail.ProductName = x.productname;
                    
                    x.order_detail.Size = x.size;
                    x.order_detail.Color = x.color;
                }
                return list.ConvertAll(x => x.order_detail);
            }
        }
        public Order_Detail GetPK(int orderId, int productId)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Order_Details.FirstOrDefault(x => x.OrderID == orderId &&
                x.ProductId == productId);
            }
        }
    }
}
