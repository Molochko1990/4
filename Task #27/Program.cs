Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (num > 0)
{
    int number = num % 10;
    num /= 10;
    result = number + result;
}
Console.WriteLine(result);