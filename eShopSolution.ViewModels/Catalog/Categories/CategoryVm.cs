using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Categories
{
    public class CategoryVm
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public int? ParentId { set; get; }
    }
}
