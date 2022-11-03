bool multipleYN (int num1, int num2)
{
    bool result = (num1 % num2 == 0);
    return result;
}

Console.WriteLine("This program check is your number multyple to 7 and 23.");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res7 = multipleYN(number, 7);

bool res23 = multipleYN(number, 23);

if (res7 is true && res23 is true)
{
    Console.WriteLine($"{number} is multiple to 7 and 23");
}
else
{
    Console.WriteLine($"{number} is not multiple to 7 or to 23 or to both");
}