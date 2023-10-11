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

        Console.WriteLine("Please enter a maximum number: ");
        int maxNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= maxNumber; i++)
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
                    if(position == -1){
                        result.Add("Fezz");
                    } else result.Insert(position, "Fezz");
                }
                else {
                    result.Clear();
                    result.Add("Fezz");
                }
            }

            if (IsDivisibleBy(i, 17)) result.Reverse();

            if (result.Count == 0) result.Add(i.ToString());

            Console.WriteLine(string.Join("", result));
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
            if(message[i][0].ToString() == "B")
            {
                result = i;
                break;
            }   
        }
        return result;
    }

    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}