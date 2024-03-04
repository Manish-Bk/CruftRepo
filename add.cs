using System;

public class NumberAdder
{
  public static void Main(string[] args)
  {
    // Declare variables to hold the numbers
    int num1, num2;

    // Get the first number from the user
    Console.WriteLine("Enter the first number: ");
    num1 = int.Parse(Console.ReadLine());

    // Get the second number from the user
    Console.WriteLine("Enter the second number: ");
    num2 = int.Parse(Console.ReadLine());

    // Calculate the sum
    int sum = num1 + num2;

    // Display the sum
    Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);
  }
}
