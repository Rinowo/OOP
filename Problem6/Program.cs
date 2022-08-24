namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Rino", 20);
            Person noName = new Person(string.Empty, 23);
            Person negativeAge = new Person("Rinu", -1);
            Person tooOldforThisProgram = new Person("Old man", 121);
        }

        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public string Name { get
                {
                    return this.name;
                }
                set
                {
                    try
                    {
                        if (string.IsNullOrEmpty(value))
                        {
                            throw new ArgumentNullException();
                        }

                        this.name = value;
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Name is blank");
                    }
                }
            }
            public int Age {
                get
                {
                    return this.age;
                }
                set
                {
                    try
                    {
                        if (value < 0 || 120 < value)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        this.age = value;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(value + "Age should be in the range [0 ... 120]");
                    }
                }
            }
        }
    }
}