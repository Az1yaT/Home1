Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 100)
{
    Console.WriteLine((n / 1) % 10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}