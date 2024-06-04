using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
            CategoryId = UniqueIdGenerator();
        }

        public Category()
        {

        }

        private string UniqueIdGenerator() => Guid.NewGuid().ToString(); 
    }
}
