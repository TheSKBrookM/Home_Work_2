namespace Home_Work_4
{
    internal class Program
    {
        static void Main()
        {
            User user = new User();

            Console.WriteLine(user.date.ToString());
            Console.WriteLine(user.Surname);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Login);

            Console.WriteLine(new string('-', 20));

            User user2 = new User("Max.Blinda@gmail.com", "Maxim", "Blinda", 26);

            Console.WriteLine(user2.date.ToString() + "\n" + user2.Surname + "\n" + user2.Name + "\n" + user2.Age + "\n" + user2.Login);


            Console.ReadKey();
        }
    }
}