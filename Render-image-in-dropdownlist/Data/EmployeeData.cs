namespace BlazorApp1.Data
{
    public class EmployeeData
    {
        public static List<EmployeeData> Employees = new List<EmployeeData>();

        public EmployeeData() { }

        public EmployeeData(
            int EmployeeID, string FirstName, string LastName,
            string Title, string Country, string City,
            DateTime HireDate, string ImageURL)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.Country = Country;
            this.City = City;
            this.HireDate = HireDate;
            this.ImageURL = ImageURL;
        }

        public static List<EmployeeData> GetAllRecords()
        {
            if (Employees.Count == 0)
            {
                Employees = new List<EmployeeData>
                {
                    new EmployeeData(1, "Nancy", "Davolio", "Sales Representative", "USA", "New York", DateTime.Parse("2012-01-01"), "scripts/Images/Employees/1.png"),
                    new EmployeeData(2, "Andrew", "Fuller", "Vice President, Sales", "UK", "London", DateTime.Parse("2010-03-15"), "scripts/Images/Employees/2.png"),
                    new EmployeeData(3, "Janet", "Leverling", "Sales Manager", "USA", "Seattle", DateTime.Parse("2015-06-23"), "scripts/Images/Employees/3.png"),
                    new EmployeeData(4, "Margaret", "Peacock", "Inside Sales Coordinator", "UAE", "Dubai", DateTime.Parse("2018-09-10"), "scripts/Images/Employees/4.png"),
                    new EmployeeData(5, "Steven", "Buchanan", "Sales Representative", "NED", "Amsterdam", DateTime.Parse("2017-04-17"), "scripts/Images/Employees/5.png"),
                    new EmployeeData(6, "Michael", "Suyama", "Sales Manager", "BER", "Berlin", DateTime.Parse("2013-02-12"), "scripts/Images/Employees/6.png"),
                    new EmployeeData(7, "Anne", "Dodsworth", "Sales Representative", "USA", "Boston", DateTime.Parse("2016-11-05"), "scripts/Images/Employees/7.png"),
                    new EmployeeData(8, "Laura", "Callahan", "Sales Coordinator", "UK", "Manchester", DateTime.Parse("2019-08-19"), "scripts/Images/Employees/8.png"),
                    new EmployeeData(9, "Robert", "King", "Sales Representative", "USA", "Los Angeles", DateTime.Parse("2020-07-21"), "scripts/Images/Employees/9.png"),
                    new EmployeeData(10, "John", "Doe", "Regional Manager", "Canada", "Toronto", DateTime.Parse("2014-05-20"), "scripts/Images/Employees/2.png")
                };
            }
            return Employees;
        }

        // Properties for Employee Data
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime HireDate { get; set; }
        public string ImageURL { get; set; }
    }
}