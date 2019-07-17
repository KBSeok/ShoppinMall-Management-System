using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class SubCategoryData
    {
        public List<String> GetSubName(string ParentsName)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            from y in context.SubCategories
                            where (x.ParentsCategoryId == y.ParentsCategoryId && x.SubCategoryId == y.SubCategoryId) 
                            && x.ParentsCategory.ParentsCategoryName == ParentsName
                            select x;

                var query1 = query.Select(x => x.SubCategory.SubCategoryName).Distinct().ToList();


                return query1;
            }
        }
    }
}
