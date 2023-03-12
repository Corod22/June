// 19. Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int NumberX()
{
    Console.WriteLine("Введите координату X");
    int numX = Convert.ToInt32(Console.ReadLine());
    return numX;
}
int NumberY()
{
    Console.WriteLine("Введите координату Y");
    int numY = Convert.ToInt32(Console.ReadLine());
    return numY;
}
string Quarter(int x1, int y1)
{
    if (x1 > 0 && y1 > 0) return "Первая четверть";
    else if (x1 < 0 && y1 > 0) return "Вторая четверть";
    else if (x1 < 0 && y1 < 0) return "Третья четверть";
    // else if (x1 > 0 && y1 < 0)
    return "Четвертая четверть";
}
int x = NumberX();
int y = NumberY();
string quarter = Quarter(x, y);
Console.WriteLine(quarter);
Console.ReadKey();