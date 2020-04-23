using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowDetailReportInPopup.Models {
    public class Product {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string EAN13 { get; set; }
        public Product(int productID, string productName, int supplierID, int categoryID, string quantityPerUnit, double unitPrice,
            int unitsInStock, int unitsOnOrder, int reorderLevel, bool discontinued, string ean13) {
            ProductID = productID;
            ProductName = productName;
            SupplierID = supplierID;
            CategoryID = categoryID;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
            EAN13 = ean13;
        }

        public static List<Product> GetData() {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Chai", 1, 1, "10 boxes x 20 bags", 18.00, 39, 0, 10, false, "070684900001"));
            products.Add(new Product(2, "Chang", 1, 1, "24 - 12 oz bottles", 19.00, 17, 40, 25, false, "070684900002"));
            products.Add(new Product(3, "Aniseed Syrup", 1, 2, "12 - 550 ml bottles", 10.00, 13, 70, 25, false, "070684900003"));
            products.Add(new Product(4, "Chef Anton's Cajun Seasoning", 2, 2, "48 - 6 oz jars", 22.00, 53, 0, 0, false, "070684900004"));
            products.Add(new Product(5, "Chef Anton's Gumbo Mix", 2, 2, "36 boxes", 21.35, 0, 0, 0, true, "070684900005"));
            products.Add(new Product(6, "Grandma's Boysenberry Spread", 3, 2, "12 - 8 oz jars", 25.00, 120, 0, 25, false, "070684900006"));
            products.Add(new Product(7, "Uncle Bob's Organic Dried Pears", 3, 7, "12 - 1 lb pkgs.", 30.00, 15, 0, 10, false, "070684900007"));
            products.Add(new Product(8, "Northwoods Cranberry Sauce", 3, 2, "12 - 12 oz jars", 40.00, 6, 0, 0, false, "070684900008"));
            products.Add(new Product(9, "Mishi Kobe Niku", 4, 6, "18 - 500 g pkgs.", 97.00, 29, 0, 0, true, "070684900009"));
            products.Add(new Product(10, "Ikura", 4, 8, "12 - 200 ml jars", 31.00, 31, 0, 0, false, "070684900010"));
            products.Add(new Product(11, "Queso Cabrales", 5, 4, "1 kg pkg.", 21.00, 22, 30, 30, false, "070684900011"));
            products.Add(new Product(12, "Queso Manchego La Pastora", 5, 4, "10 - 500 g pkgs.", 38.00, 86, 0, 0, false, "070684900012"));
            products.Add(new Product(13, "Konbu", 6, 8, "2 kg box", 6.00, 24, 0, 5, false, "070684900013"));
            products.Add(new Product(14, "Tofu", 6, 7, "40 - 100 g pkgs.", 23.25, 35, 0, 0, false, "070684900014"));
            products.Add(new Product(15, "Genen Shouyu", 6, 2, "24 - 250 ml bottles", 15.50, 39, 0, 5, false, "070684900015"));
            products.Add(new Product(16, "Pavlova", 7, 3, "32 - 500 g boxes", 17.45, 29, 0, 10, false, "070684900016"));
            products.Add(new Product(17, "Alice Mutton", 7, 6, "20 - 1 kg tins", 39.00, 0, 0, 0, true, "070684900017"));
            products.Add(new Product(18, "Carnarvon Tigers", 7, 8, "16 kg pkg.", 62.50, 42, 0, 0, false, "070684900018"));
            products.Add(new Product(19, "Teatime Chocolate Biscuits", 8, 3, "10 boxes x 12 pieces", 9.20, 25, 0, 5, false, "070684900019"));
            products.Add(new Product(20, "Sir Rodney's Marmalade", 8, 3, "30 gift boxes", 81.00, 40, 0, 0, false, "070684900020"));
            products.Add(new Product(21, "Sir Rodney's Scones", 8, 3, "24 pkgs. x 4 pieces", 10.00, 3, 40, 5, false, "070684900021"));
            products.Add(new Product(22, "Gustaf's Knäckebröd", 9, 5, "24 - 500 g pkgs.", 21.00, 104, 0, 25, false, "070684900022"));
            products.Add(new Product(23, "Tunnbröd", 9, 5, "12 - 250 g pkgs.", 9.00, 61, 0, 25, false, "070684900023"));
            products.Add(new Product(24, "Guaraná Fantástica", 10, 1, "12 - 355 ml cans", 4.50, 20, 0, 0, true, "070684900024"));
            products.Add(new Product(25, "NuNuCa Nuß-Nougat-Creme", 11, 3, "20 - 450 g glasses", 14.00, 76, 0, 30, false, "070684900025"));
            products.Add(new Product(26, "Gumbär Gummibärchen", 11, 3, "100 - 250 g bags", 31.23, 15, 0, 0, false, "070684900026"));
            products.Add(new Product(27, "Schoggi Schokolade", 11, 3, "100 - 100 g pieces", 43.90, 49, 0, 30, false, "070684900027"));
            products.Add(new Product(28, "Rössle Sauerkraut", 12, 7, "25 - 825 g cans", 45.60, 26, 0, 0, true, "070684900028"));
            products.Add(new Product(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79, 0, 0, 0, true, "070684900029"));
            products.Add(new Product(30, "Nord-Ost Matjeshering", 13, 8, "10 - 200 g glasses", 25.89, 10, 0, 15, false, "070684900030"));
            products.Add(new Product(31, "Gorgonzola Telino", 14, 4, "12 - 100 g pkgs", 12.50, 0, 70, 20, false, "070684900031"));
            products.Add(new Product(32, "Mascarpone Fabioli", 14, 4, "24 - 200 g pkgs.", 32.00, 9, 40, 25, false, "070684900032"));
            products.Add(new Product(33, "Geitost", 15, 4, "500 g", 2.50, 112, 0, 20, false, "070684900033"));
            products.Add(new Product(34, "Sasquatch Ale", 16, 1, "24 - 12 oz bottles", 14.00, 111, 0, 15, false, "070684900034"));
            products.Add(new Product(35, "Steeleye Stout", 16, 1, "24 - 12 oz bottles", 18.00, 20, 0, 15, false, "070684900035"));
            products.Add(new Product(36, "Inlagd Sill", 17, 8, "24 - 250 g  jars", 19.00, 112, 0, 20, false, "070684900036"));
            products.Add(new Product(37, "Gravad lax", 17, 8, "12 - 500 g pkgs.", 26.00, 11, 50, 25, false, "070684900037"));
            products.Add(new Product(38, "Côte de Blaye", 18, 1, "12 - 75 cl bottles", 263.50, 17, 0, 15, false, "070684900038"));
            products.Add(new Product(39, "Chartreuse verte", 18, 1, "750 cc per bottle", 18.00, 69, 0, 5, false, "070684900039"));
            products.Add(new Product(40, "Boston Crab Meat", 19, 8, "24 - 4 oz tins", 18.40, 123, 0, 30, false, "070684900040"));
            products.Add(new Product(41, "Jack's New England Clam Chowder", 19, 8, "12 - 12 oz cans", 9.65, 85, 0, 10, false, "070684900041"));
            products.Add(new Product(42, "Singaporean Hokkien Fried Mee", 20, 5, "32 - 1 kg pkgs.", 14.00, 26, 0, 0, true, "070684900042"));
            products.Add(new Product(43, "Ipoh Coffee", 20, 1, "16 - 500 g tins", 46.00, 17, 10, 25, false, "070684900043"));
            products.Add(new Product(44, "Gula Malacca", 20, 2, "20 - 2 kg bags", 19.45, 27, 0, 15, false, "070684900044"));
            products.Add(new Product(45, "Røgede sild", 21, 8, "1k pkg.", 9.50, 5, 70, 15, false, "070684900045"));
            products.Add(new Product(46, "Spegesild", 21, 8, "4 - 450 g glasses", 12.00, 95, 0, 0, false, "070684900046"));
            products.Add(new Product(47, "Zaanse koeken", 22, 3, "10 - 4 oz boxes", 9.50, 36, 0, 0, false, "070684900047"));
            products.Add(new Product(48, "Chocolade", 22, 3, "10 pkgs.", 12.75, 15, 70, 25, false, "070684900048"));
            products.Add(new Product(49, "Maxilaku", 23, 3, "24 - 50 g pkgs.", 20.00, 10, 60, 15, false, "070684900049"));
            products.Add(new Product(50, "Valkoinen suklaa", 23, 3, "12 - 100 g bars", 16.25, 65, 0, 30, false, "070684900050"));
            products.Add(new Product(51, "Manjimup Dried Apples", 24, 7, "50 - 300 g pkgs.", 53.00, 20, 0, 10, false, "070684900051"));
            products.Add(new Product(52, "Filo Mix", 24, 5, "16 - 2 kg boxes", 7.00, 38, 0, 25, false, "070684900052"));
            products.Add(new Product(53, "Perth Pasties", 24, 6, "48 pieces", 32.80, 0, 0, 0, true, "070684900053"));
            products.Add(new Product(54, "Tourtière", 25, 6, "16 pies", 7.45, 21, 0, 10, false, "070684900054"));
            products.Add(new Product(55, "Pâté chinois", 25, 6, "24 boxes x 2 pies", 24.00, 115, 0, 20, false, "070684900055"));
            products.Add(new Product(56, "Gnocchi di nonna Alice", 26, 5, "24 - 250 g pkgs.", 38.00, 21, 10, 30, false, "070684900056"));
            products.Add(new Product(57, "Ravioli Angelo", 26, 5, "24 - 250 g pkgs.", 19.50, 36, 0, 20, false, "070684900057"));
            products.Add(new Product(58, "Escargots de Bourgogne", 27, 8, "24 pieces", 13.25, 62, 0, 20, false, "070684900058"));
            products.Add(new Product(59, "Raclette Courdavault", 28, 4, "5 kg pkg.", 55.00, 79, 0, 0, false, "070684900059"));
            products.Add(new Product(60, "Camembert Pierrot", 28, 4, "15 - 300 g rounds", 34.00, 19, 0, 0, false, "070684900060"));
            products.Add(new Product(61, "Sirop d'érable", 29, 2, "24 - 500 ml bottles", 28.50, 113, 0, 25, false, "070684900061"));
            products.Add(new Product(62, "Tarte au sucre", 29, 3, "48 pies", 49.30, 17, 0, 0, false, "070684900062"));
            products.Add(new Product(63, "Vegie-spread", 7, 2, "15 - 625 g jars", 43.90, 24, 0, 5, false, "070684900063"));
            products.Add(new Product(64, "Wimmers gute Semmelknödel", 12, 5, "20 bags x 4 pieces", 33.25, 22, 80, 30, false, "070684900064"));
            products.Add(new Product(65, "Louisiana Fiery Hot Pepper Sauce", 2, 2, "32 - 8 oz bottles", 21.05, 76, 0, 0, false, "070684900065"));
            products.Add(new Product(66, "Louisiana Hot Spiced Okra", 2, 2, "24 - 8 oz jars", 17.00, 4, 100, 20, false, "070684900066"));
            products.Add(new Product(67, "Laughing Lumberjack Lager", 16, 1, "24 - 12 oz bottles", 14.00, 52, 0, 10, false, "070684900067"));
            products.Add(new Product(68, "Scottish Longbreads", 8, 3, "10 boxes x 8 pieces", 12.50, 6, 10, 15, false, "070684900068"));
            products.Add(new Product(69, "Gudbrandsdalsost", 15, 4, "10 kg pkg.", 36.00, 26, 0, 15, false, "070684900069"));
            products.Add(new Product(70, "Outback Lager", 7, 1, "24 - 355 ml bottles", 15.00, 15, 10, 30, false, "070684900070"));
            products.Add(new Product(71, "Fløtemysost", 15, 4, "10 - 500 g pkgs.", 21.50, 26, 0, 0, false, "070684900071"));
            products.Add(new Product(72, "Mozzarella di Giovanni", 14, 4, "24 - 200 g pkgs.", 34.80, 14, 0, 0, false, "070684900072"));
            products.Add(new Product(73, "Röd Kaviar", 17, 8, "24 - 150 g jars", 15.00, 101, 0, 5, false, "070684900073"));
            products.Add(new Product(74, "Longlife Tofu", 4, 7, "5 kg pkg.", 10.00, 4, 20, 5, false, "070684900074"));
            products.Add(new Product(75, "Rhönbräu Klosterbier", 12, 1, "24 - 0.5 l bottles", 7.75, 125, 0, 25, false, "070684900075"));
            products.Add(new Product(76, "Lakkalikööri", 23, 1, "500 ml", 18.00, 57, 0, 20, false, "070684900076"));
            products.Add(new Product(77, "Original Frankfurter grüne Soße", 12, 2, "12 boxes", 13.00, 32, 0, 15, false, "070684900077"));
            return products;
        }
    }
}
