// See https://aka.ms/new-console-template for more information
Console.WriteLine("Проверка четность числа");
Console.Write("Введите число: " );
int num = Convert.ToInt32 (Console.ReadLine());
if (num % 2 == 0) 
{
    Console.WriteLine("число " + num + " четное");
} else
{
    Console.WriteLine("число " + num + " нечетное");
}


