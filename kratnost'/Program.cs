Console.WriteLine("This program assepts two numbers and print is second number multiple for first");
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter srcond number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int ostatok = 0;
if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1} is multyple {num2}");
}
else 
{
    ostatok = num1 % num2;
    Console.WriteLine($"{num1} is not multyple {num2}. Remainder of division is {ostatok}");
}