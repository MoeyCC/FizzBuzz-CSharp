namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        Console.WriteLine("Welcome to FizzBuzz!");
        Console.WriteLine("====================");
        Console.WriteLine();

        List<string> message = new List<string>();

        //**************************************************************************

        /* message.Add("Fezz");
        message.Add("Ping");
        message.Add("Fuzz");
        message.Add("Song");

        int result = IsFoundLetter(message, "B");

        if(result != -1){
            Console.WriteLine("Letter B found in position {0}", result);
        } else {
            Console.WriteLine("Letter B not found!");
        }; */
        
        //************************************************************************

        

        for (int i = 1; i < 301; i++)
        {
            message.Clear();
            if (IsDivisibleBy(i, 3)) message.Add("Fizz");

            if (IsDivisibleBy(i, 5)) message.Add("Buzz");

            if (IsDivisibleBy(i, 7)) message.Add("Bang");

            if (IsDivisibleBy(i, 11))
            {
                message.Clear();
                message.Add("Bong");
            }

            if (IsDivisibleBy(i, 13))
            {
                if (message.Count > 0)
                {
                    int result = IsFoundLetter(message, "B");
                    if(result == -1){
                        message.Add("Fezz");
                    } else message.Insert(result, "Fezz");
                }
                else {
                    message.Clear();
                    message.Add("Fezz");
                }
            }

            if (IsDivisibleBy(i, 17)) message.Reverse();

            if (message.Count == 0) message.Add(i.ToString());

            Console.WriteLine(string.Join("", message));
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