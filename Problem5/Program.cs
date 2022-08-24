namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1,
                b = 2,
                c = 3;

            try
            {
                b = Convert.ToDouble("123.45-6");
            }
            catch (FormatException)
            {
                Console.WriteLine("We got a FormatException");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("We got a OverflowException");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("We got another Exception");
                throw;
            }

            try
            {
                c = Convert.ToDouble("123402933333333123");
            }
            catch (FormatException)
            {
                Console.WriteLine("We got a FormatException");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("We got a OverflowException");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("We got another Exception");
                throw;
            }

            Console.WriteLine("a:" + a +"\nb:" + b + "\nc" + c);
        }
    }
}