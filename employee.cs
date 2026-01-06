namespace CompanyApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}");
        }
    }
}
