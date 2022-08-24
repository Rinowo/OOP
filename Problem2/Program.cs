namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }

        static void ReadNumber(int start, int end)
        {
            int[] allNumber = new int[10];

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    allNumber[1] = int.Parse(Console.ReadLine());

                    if (allNumber[i] < start || allNumber[i] > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format of input");
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number is out of the range!");
                    break;
                }
                start = allNumber[i];
            }
        }

    }
}