namespace BlazorApp1.Data
{
    public class EmployeeDetails
    {
        // Constructor
        public EmployeeDetails() { }

        public EmployeeDetails(int employeeID, string firstName, string lastName, string title)
        {
            EmployeeID = employeeID;
            Name = new Name { FirstName = firstName, LastName = lastName };
            Title = title;
        }

        // Static method to return all employee records
        public static List<EmployeeDetails> GetAllRecords()
        {
            return new List<EmployeeDetails>
            {
                new EmployeeDetails(1, "Nancy", "Davolio", "Sales Representative"),
                new EmployeeDetails(2, "Andrew", "Fuller", "Vice President, Sales"),
                new EmployeeDetails(3, "Janet", "Leverling", "Sales Manager"),
                new EmployeeDetails(4, "Margaret", "Peacock", "Inside Sales Coordinator"),
                new EmployeeDetails(5, "Steven", "Buchanan", "Sales Representative"),
                new EmployeeDetails(6, "Michael", "Suyama", "Marketing Coordinator"),
                new EmployeeDetails(7, "Robert", "King", "Sales Representative"),
                new EmployeeDetails(8, "Laura", "Callahan", "Marketing Specialist"),
                new EmployeeDetails(9, "Anne", "Dodsworth", "Sales Manager"),
                new EmployeeDetails(10, "Andrew", "Davies", "Vice President, Operations")
            };
        }

        public int EmployeeID { get; set; }
        public Name Name { get; set; }
        public string Title { get; set; }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
