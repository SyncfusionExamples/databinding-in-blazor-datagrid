public class OrderData1
{
    public static List<OrderData1> Orders = new List<OrderData1>();

    public OrderData1() { }

    public OrderData1(int? orderId, string customerId, double freight, string title, string orderStatus,
                      int quantity, DateTime orderDate, string shipAddress)
    {
        OrderID = orderId;
        CustomerID = customerId;
        Freight = freight;
        Title = title;
        OrderStatus = orderStatus;
        Quantity = quantity;
        OrderDate = orderDate;
        ShipAddress = shipAddress;
    }

    public static List<OrderData1> GetAllRecords()
    {
        if (Orders.Count == 0)
        {
            int code = 10;
            for (int i = 1; i < 2; i++)
            {
                Orders.Add(new OrderData1(10248, "Nancy", 32.14, "Sales Representative", "Order Placed", 5, DateTime.Now.AddDays(-10), "123 Main St, City A"));
                Orders.Add(new OrderData1(10249, "Andrew", 33.33, "Vice President, Sales", "Processing", 10, DateTime.Now.AddDays(-8), "456 Oak St, City B"));
                Orders.Add(new OrderData1(10250, "Janet", 56.78, "Sales Manager", "Delivered", 15, DateTime.Now.AddDays(-6), "789 Pine St, City C"));
                Orders.Add(new OrderData1(10251, "Margaret", 43.34, "Inside Sales Coordinator", "Delivered", 20, DateTime.Now.AddDays(-4), "101 Maple Ave, City D"));
                Orders.Add(new OrderData1(10252, "Steven", 17.98, "Sales Manager", "Delivered", 12, DateTime.Now.AddDays(-2), "202 Birch Rd, City E"));
                Orders.Add(new OrderData1(10253, "Michael", 53.33, "Sales Representative", "Processing", 8, DateTime.Now, "303 Elm Dr, City F"));
                Orders.Add(new OrderData1(10254, "Robert", 78.99, "Vice President, Sales", "Delivered", 25, DateTime.Now.AddDays(1), "404 Cedar St, City G"));
                Orders.Add(new OrderData1(10255, "Anne", 46.66, "Inside Sales Coordinator", "Order Placed", 30, DateTime.Now.AddDays(2), "505 Walnut St, City H"));
                Orders.Add(new OrderData1(10256, "Laura", 98.76, "Sales Manager", "Delivered", 18, DateTime.Now.AddDays(3), "606 Ash Blvd, City I"));
                code += 5;
            }
        }
        return Orders;
    }

    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public double Freight { get; set; }
    public string Title { get; set; }
    public string OrderStatus { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipAddress { get; set; }
}
