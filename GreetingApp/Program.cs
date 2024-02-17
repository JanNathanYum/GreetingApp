namespace GreetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name;
            name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int courses;
            courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the the price of your favorite book: ");
            double book;
            book = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + courses);
            Console.WriteLine("Price of the book: "+  book);
        }
    }
}