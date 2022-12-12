using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3
{
    internal class Invoice
    {
        public readonly int account = 0;
        public readonly string customer = null;
        public readonly string provider = null;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CostCalculate(bool NeedPDV)
        {
            double cost;
            switch (Article)
            {
                case "Комп'ютер": cost = 20000;
                    break;
                case "Ноутбук": cost = 25000;
                    break;
                case "Моноблок": cost = 30000;
                    break;
                case "Смартфон": cost = 10000;
                    break;
                default: Console.WriteLine("Товару немає в наявностi");
                    return;
            }
            if (NeedPDV)
            {
                cost = cost + (cost * 0.2);  
            }
            Console.WriteLine($"Сума до оплати: {cost * Quantity} UAH");
        }

    }
}
