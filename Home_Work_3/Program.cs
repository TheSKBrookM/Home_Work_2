using System.Linq.Expressions;

namespace Home_Work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(002121, "Max", "Comfy");

            invoice.Article = "Ноутбук";
            invoice.Quantity = 5;

            invoice.CostCalculate(true);
            invoice.CostCalculate(false);

            Console.ReadKey();
        }
    }
}