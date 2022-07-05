Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
int newNum = 0;

if(n < 99)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
while(n > 99)
{
    newNum = n % 10;
    n = n / 10;
    Console.WriteLine($"Третья цифра числа = {newNum}");
    return;
}