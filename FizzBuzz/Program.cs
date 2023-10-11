namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        Console.WriteLine("Welcome to FizzBuzz!");
        Console.WriteLine("====================");
        Console.WriteLine();

        List<string> result = new List<string>();

#nullable disable

        while (true)
        {
            Console.Write("Please enter a maximum number: ");
            string input = Console.ReadLine();

            CheckExitProgram(input);

            int count;
            int.TryParse(input, out count);
            if (count != 0)
            {
                for (int i = 1; i <= count; i++)
                {
                    result.Clear();
                    if (IsDivisibleBy(i, 3)) result.Add("Fizz");

                    if (IsDivisibleBy(i, 5)) result.Add("Buzz");

                    if (IsDivisibleBy(i, 7)) result.Add("Bang");

                    if (IsDivisibleBy(i, 11))
                    {
                        result.Clear();
                        result.Add("Bong");
                    }

                    if (IsDivisibleBy(i, 13))
                    {
                        if (result.Count > 0)
                        {
                            int position = IsFoundLetter(result, "B");
                            if (position == -1) result.Add("Fezz");
                            else result.Insert(position, "Fezz");
                        }
                        else
                        {
                            result.Clear();
                            result.Add("Fezz");
                        }
                    }

                    if (IsDivisibleBy(i, 17)) result.Reverse();

                    if (result.Count == 0) result.Add(i.ToString());

                    Console.WriteLine(string.Join("", result));
                }
            }
        }
    }

    private static bool IsDivisibleBy(int numerator, int denominator)
    {
        return numerator % denominator == 0;
    }

    private static int IsFoundLetter(List<string> message, string letter)
    {
        int result = -1;
        for (int i = 0; i < message.Count(); i++)
        {
            if (message[i][0].ToString() == "B")
            {
                result = i;
                break;
            }
        }
        return result;
    }

    private static void CheckExitProgram(string input)
    {
        if(input == "Exit") Environment.Exit(0);
    }

    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}