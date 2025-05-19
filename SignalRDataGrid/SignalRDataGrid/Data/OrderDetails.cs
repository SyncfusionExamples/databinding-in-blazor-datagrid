namespace SignalRDataGrid.Data
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ShipName { get; set; }

        public static List<OrderDetails> OrderList = new List<OrderDetails>();

        private static readonly string[] CustomerIDs = new[]
        {
        "VINET", "TOMSP", "HANAR", "VICTE", "SUPRD", "CHOPS", "RICSU", "WELLI", "HILAA", "ERNSH", "CENTC", "OTTIK", "QUEDE", "RATTC"
        };

        private static readonly string[] ShipNames = new[]
        {
        "Vins et alcools Chevalier", "Toms Spezialitäten", "Hanari Carnes", "Victuailles en stock", "Suprêmes délices",
        "Chop-suey Chinese", "Richter Supermarkt", "Wellington Importadora", "HILARION-Abastos", "Ernst Handel",
        "Centro comercial Moctezuma", "Ottilies Käseladen", "Que Delícia", "Rattlesnake Canyon Grocery"
        };

        public static Task<List<OrderDetails>> GetOrdersAsync()
        {
            var rng = new Random();
            if (OrderList.Count == 0)
            {
                OrderList = Enumerable.Range(10248, 75).Select(index => new OrderDetails
                {
                    OrderID = index,
                    CustomerID = CustomerIDs[rng.Next(CustomerIDs.Length)],
                    ShipName = ShipNames[rng.Next(ShipNames.Length)]
                }).ToList();
            }

            return Task.FromResult(OrderList);
        }

        public Task<OrderDetails> UpdateAsync(OrderDetails model)
        {
            var ord = OrderList.Where(x => x.OrderID == model.OrderID).FirstOrDefault();
            ord.CustomerID = model.CustomerID;
            ord.ShipName = model.ShipName;
            return Task.FromResult(model);
        }
        public List<OrderDetails> DeleteAsync(OrderDetails model)
        {
            var ord = OrderList.Remove(model);

            return OrderList;
        }

    }
}
