namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt16(Console.ReadLine());

            try
            {
                if (a < 0)
                {
                    throw new Exception();
                }
                else
                {
                    double b = Math.Sqrt(a);
                    Console.WriteLine(Math.Sqrt(a));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            Console.ReadKey();
        }
    }
}