Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Максимальное число" );
    Console.WriteLine(number1);
}

if(number1 < number2)
{
    Console.WriteLine("Максимальное число" );
    Console.WriteLine(number2);
}