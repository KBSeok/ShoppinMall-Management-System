using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Data
{
    class ProductData : EntityData<Product>
    {
        public List<Product> SearchInfo(string Name, string Parents, string Sub,
            string Size, string Color)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;
                query.ToList();

                if (string.IsNullOrEmpty(Name) == false)
                {
                    query = from x in query
                            where x.ProductName == Name
                            select x;
                    query.ToList();
                }

                if (string.IsNullOrEmpty(Parents) == false)
                {
                    query = from x in query
                            where x.ParentsCategory.ParentsCategoryName == Parents
                            select x;
                    query.ToList();
                }

                if(string.IsNullOrEmpty(Sub) == false)
                {
                    query = from x in query
                            where x.SubCategory.SubCategoryName == Sub
                            select x;
                    query.ToList();
                }
                if (string.IsNullOrEmpty(Size) == false)
                {
                    query = from x in query
                            where x.Size == Size
                            select x;
                    query.ToList();
                }

                if (string.IsNullOrEmpty(Color) == false)
                {
                    query = from x in query
                            where x.Color == Color
                            select x;
                    query.ToList();
                }

                return query.ToList();
            }
        }

        public List<Product> GetProductInfo()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;

                return query.ToList();
            }
        }

        public List<string> GetColor(string ParentsName, string SubName)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            from y in context.SubCategories
                            where (x.ParentsCategoryId == y.ParentsCategoryId 
                            && x.SubCategoryId == y.SubCategoryId)
                            && x.ParentsCategory.ParentsCategoryName == ParentsName 
                            && x.SubCategory.SubCategoryName == SubName
                            select x;

                var query1 = query.Select(x => x.Color).Distinct().ToList();

                return query1;
            }
        }

        public List<string> GetSize(string ParentsName, string SubName, string Color)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            from y in context.SubCategories
                            where (x.ParentsCategoryId == y.ParentsCategoryId
                            && x.SubCategoryId == y.SubCategoryId)
                            && x.ParentsCategory.ParentsCategoryName == ParentsName
                            && x.SubCategory.SubCategoryName == SubName
                            && x.Color == Color
                            select x;

                var query1 = query.Select(x => x.Size).Distinct().ToList();

                return query1;
            }
        }

        public int GetByPK(string productName, string size, string color)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            where x.ProductName == productName && x.Size == size && x.Color == color
                            select x;
                var productId = (query.Select(x => x.ProductId).First());

                return productId;
            }
        }

        public void DeliveredProduct()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                Product product = new Product();
                string shippedDate = DateTime.Now.ToString("yy.MM.dd");
                //배송 날짜가 오늘날짜와 같은 상품주문서 찾기
                var query = from x in context.ProductOrders
                            where x.ShippedDate == shippedDate
                            select x;

                //배송되는 상품 기본키 찾기
                var pk = query.Select(x => x.ProductId).ToList();

                var orderAmount = query.Select(x => x.Amount).ToList();

                for (int i = 0; i < query.Count(); i++)
                {
                    int productId = pk[i];
                    var productInfo = from x in context.Products
                                      where x.ProductId == productId
                                      select x;

                    var stockAmount = productInfo.Select(x => x.StockAmount).First();

                    if (stockAmount <= 5)
                    {
                        var productName = productInfo.Select(x => x.ProductName).First();
                        var parentsCategoryId = productInfo.Select(x => x.ParentsCategoryId).First();
                        var subCategoryId = productInfo.Select(x => x.SubCategoryId).First();
                        var size = productInfo.Select(x => x.Size).First();
                        var color = productInfo.Select(x => x.Color).First();
                        var price = productInfo.Select(x => x.Price).First();

                        product.ProductId = pk[i];
                        product.ProductName = productName;
                        product.ParentsCategoryId = parentsCategoryId;
                        product.SubCategoryId = subCategoryId;
                        product.Size = size;
                        product.Color = color;
                        product.Price = price;
                        product.StockAmount += orderAmount[i];

                        DB.Product.Update(product);

                        MessageBox.Show("입고되었습니다.", "알림", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

            }
        }

    }
}
