int number = new Random().Next(100, 1000);

int hundreds = number / 100;
hundreds = hundreds * 10;
int LastDigit = number % 10;

int NumberEnd = hundreds + LastDigit;

Console.WriteLine($"Random number is {number}");
Console.WriteLine($"Result is {NumberEnd}");