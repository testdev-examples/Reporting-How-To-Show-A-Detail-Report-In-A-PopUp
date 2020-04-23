using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowDetailReportInPopup.Models {
    public class Category {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category(int categoryID, string categoryName, string description) {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
        }

        public static List<Category> GetData() {
            List<Category> categories = new List<Category>();
            categories.Add(new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"));
            categories.Add(new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"));
            categories.Add(new Category(3, "Confections", "Desserts, candies, and sweet breads"));
            categories.Add(new Category(4, "Dairy Products", "Cheeses"));
            categories.Add(new Category(5, @"Grains / Cereals", "Breads, crackers, pasta, and cereal"));
            categories.Add(new Category(6, @"Meat / Poultry", "Prepared meats"));
            categories.Add(new Category(7, "Produce", "Dried fruit and bean curd"));
            categories.Add(new Category(8, "Seafood", "Seaweed and fish"));
            return categories;
        }
    }
}
