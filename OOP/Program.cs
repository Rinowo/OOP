namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = new string[5];
            weekdays[0] = "Sunday";
            weekdays[1] = "Monday";
            weekdays[2] = "Tuesday";
            weekdays[3] = "Wednesday";
            weekdays[4] = "Thursday";
            weekdays[5] = "Saturday";

            try
            {
                for (int i = 0; i < weekdays[i].Length; i++)
                {
                    Console.WriteLine(weekdays[i].ToString());
                }
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex);

            }
        }
    }
}