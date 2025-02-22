namespace MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int smallPrice = 25;
            const int largePrice = 35;
            const float taxRate = 6f;

            Console.Write("Enter number of small carpets : ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of large carpets : ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Price per small room: {smallPrice:C0}");
            Console.WriteLine($"Price per large room: {largePrice:C0}");

            int cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
            Console.WriteLine($"Cost : {cost:C0}");

            float tax = cost - (cost - (cost * (taxRate / 100)));
            Console.WriteLine($"Tax : {tax:C1}");

            Console.WriteLine($"Total estimate: {cost + tax:C2}\nThis estimate is valid for 30 days");
        }
    }
}
