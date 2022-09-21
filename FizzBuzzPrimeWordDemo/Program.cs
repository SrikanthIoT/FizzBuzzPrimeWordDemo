using System;
using System.Net;

public class Program
{
    private String[] UnitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    private String[] TensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    public string GetFizzBuzzResult(int i)
    {
        string result = "";
        if (i > 0)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result += "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result += "Fizz";
            }
            else if (i % 5 == 0)
            {
                result += "Buzz";
            }
            else if (IsPrime(i))
            {
                result += $"PRIME - {i}";
            }
            else
            {
                result = NumToWords(i);
            }
        }
        return result;
    }

    public bool IsPrime(int i)
    {
        bool IsPrime = true;
        if (i > 1)
        {
            for (int j = 2; j <= 100; j++)
            {
                if (i != j && i % j == 0)
                {
                    IsPrime = false;
                    break;
                }

            }
        }
        else
        {
            IsPrime = false;
        }
        return IsPrime;
    }

    public string NumToWords(int i)
    {
        string resultWords = "";

        if (i > 0)
        {
            if (!string.IsNullOrWhiteSpace(resultWords))
                resultWords += "and ";

            if (i < 20)
            {
                resultWords += UnitsMap[i];
            }
            else
            {
                resultWords += TensMap[i / 10];
                if ((i % 10) > 0)
                    resultWords += "-" + UnitsMap[i % 10];
            }
        }

        return resultWords;
    }

    public static void Main(String[] args)
    {
        Program fizzBuzz = new Program();
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.GetFizzBuzzResult(i));
        }
    }
}



