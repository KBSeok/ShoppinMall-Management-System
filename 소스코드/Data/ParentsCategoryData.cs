using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class ParentsCategoryData
    {
        public List<String> GetParentsCategoryName()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.ParentsCategories.
                    Select(x => x.ParentsCategoryName).Distinct().ToList();
            }
        }
        
        
    }
}
