using System;

public class PrimeChecker
{
  public static void Main(string[] args)
  {
    int num;

    Console.WriteLine("Enter a positive number: ");
    num = int.Parse(Console.ReadLine());

    if (IsPrime(num))
    {
      Console.WriteLine("{0} is a prime number", num);
    }
    else
    {
      Console.WriteLine("{0} is not a prime number", num);
    }
  }

  public static bool IsPrime(int number)
  {
    if (number <= 1) return false;  // 1 or less are not prime
    if (number <= 3) return true;   // 2 and 3 are prime

    // Only check divisibility up to the square root of the number
    int i = 2;
    while (i * i <= number)
    {
      if (number % i == 0) return false;
      i++;
    }

    return true;
  }
}
