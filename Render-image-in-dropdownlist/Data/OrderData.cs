namespace BlazorApp1.Data
{
    public class OrderData
    {
        public static List<OrderData> Orders = new List<OrderData>();

        public OrderData() { }

        public OrderData(int OrderID, string CustomerID, string ShipName, double Freight, DateTime OrderDate, DateTime? ShippedDate, bool? IsVerified, string ShipCity, string ShipCountry, string ShipAddress, int employeeID, TimeOnly? OrderTime, string CustomerNumber)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.ShipName = ShipName;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShippedDate = ShippedDate;
            this.IsVerified = IsVerified;
            this.ShipCity = ShipCity;
            this.ShipCountry = ShipCountry;
            this.ShipAddress = ShipAddress;
            this.EmployeeID = employeeID;
            this.OrderTime = OrderTime;
            this.CustomerNumber = CustomerNumber;
        }

        public static List<OrderData> GetAllRecords()
        {
            if (Orders.Count == 0)
            {
                Orders.Add(new OrderData(10248, "VINET", "Vins et alcools Chevalier", 32.38, new DateTime(1996, 7, 4, 9, 30, 0), new DateTime(1996, 08, 07), true, "Reims", "France", "12 Rue des Fleurs", 1, new TimeOnly(9, 30, 0), "9755378589"));
                Orders.Add(new OrderData(10249, "TOMSP", "Toms Spezialitäten", 11.61, new DateTime(1996, 7, 5, 10, 0, 0), new DateTime(1996, 08, 07), false, "Münster", "Germany", "45 Straße der Nationen", 2, new TimeOnly(10, 0, 0), "9876543210"));
                Orders.Add(new OrderData(10250, "HANAR", "Hanari Carnes", 65.83, new DateTime(1996, 7, 6, 14, 15, 0), new DateTime(1996, 08, 07), true, "Rio de Janeiro", "India", "89 MG Road", 3, new TimeOnly(14, 15, 0), "9123456789"));
                Orders.Add(new OrderData(10251, "VINET", "Vins et alcools Chevalier", 41.34, new DateTime(1996, 7, 7, 11, 45, 0), new DateTime(1996, 08, 07), false, "Lyon", "France", "23 Rue Victor Hugo", 4, new TimeOnly(11, 45, 0), "9012345678"));
                Orders.Add(new OrderData(10252, "SUPRD", "Suprêmes délices", 151.30, new DateTime(1996, 7, 8, 13, 0, 0), new DateTime(1996, 08, 07), true, "Charleroi", "Belgium", "78 Rue de l'Industrie", 5, new TimeOnly(13, 0, 0), "8888888888"));
                Orders.Add(new OrderData(10253, "HANAR", "Hanari Carnes", 58.17, new DateTime(1996, 7, 9, 16, 30, 0), new DateTime(1996, 08, 07), false, "Bern", "Switzerland", "5 Bahnhofstrasse", 6, new TimeOnly(16, 30, 0), "7777777777"));
                Orders.Add(new OrderData(10254, "CHOPS", "Chop-suey Chinese", 22.98, new DateTime(1996, 7, 10, 8, 0, 0), new DateTime(1996, 08, 07), true, "Genève", "Switzerland", "12 Rue de Mont Blanc", 7, new TimeOnly(8, 0, 0), "6666666666"));
                Orders.Add(new OrderData(10255, "VINET", "Vins et alcools Chevalier", 148.33, new DateTime(1996, 7, 11, 10, 30, 0), new DateTime(1996, 08, 07), false, "Resende", "India", "7 Residency Road", 8, new TimeOnly(10, 30, 0), "9999999999"));
                Orders.Add(new OrderData(10256, "HANAR", "Hanari Carnes", 13.97, new DateTime(1996, 7, 12, 9, 45, 0), new DateTime(1996, 08, 07), true, "Paris", "France", "15 Rue de Rivoli", 9, new TimeOnly(9, 45, 0), "5555555555"));
            }
            return Orders;
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ShipName { get; set; }
        public double? Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public bool? IsVerified { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipAddress { get; set; }
        public int EmployeeID { get; set; }
        public TimeOnly? OrderTime { get; set; }
        public string CustomerNumber { get; set; } 
    }
}
