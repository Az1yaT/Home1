Console.Clear();
Console.WriteLine("Введите число дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:case 2:case 3:case 4:case 5: Console.WriteLine("Нет");
    break;
    case 6:case 7: Console.WriteLine("Да");
    break;
    default: Console.WriteLine("Нет такого дня недели");
    break;
}

