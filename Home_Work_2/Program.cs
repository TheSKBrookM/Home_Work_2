namespace Home_Work_2
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Максим", "Блинда");
            employee.Position = "junior";
            employee.Expirience = 2;

            Console.WriteLine(employee.Surname + " " + employee.Name + " - " + employee.Position);
            employee.Show();

            Console.ReadKey();
        }
    }
}