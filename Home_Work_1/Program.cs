namespace Home_Work_1
{
    internal class Program
    {
        static void Main()
        {
            Converter convert = new Converter(36.74, 38.4, 8.17);

            convert.ToUSD(100);

            convert.FromUSD(100);

            convert.ToEUR(100);

            convert.FromEUR(100);

            convert.ToPLN(100);

            convert.FromPLN(100);

            Console.ReadKey();
        }
    }
}