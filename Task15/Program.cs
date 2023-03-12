// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число N");
int numberN=Convert.ToInt32(Console.ReadLine());

string output = NumberN2(numberN) ? "Число кратное 7":"Число не кратно 7 ";
string output2 = NumberN3(numberN) ? "Число кратное 23":"Число не кратно 23 ";
Console.WriteLine(output);
Console.WriteLine(output2);
//  if (numberN%7==0) Console.WriteLine($"Число кратное 7");

// if (numberN%23==0) Console.WriteLine($"Число кратное 23");
// else Console.WriteLine($"Число не кратно 7 и 23");
Console.ReadKey();

bool NumberN2 (int num2)
{
    if (num2%7==0) return true; 
    return false;
}
bool NumberN3 (int num3)
{
    if (num3%23==0) return true;
    return false;
}

// void Number (int num)
// {
// Console.WriteLine("Введите число N");
// int numberN=Convert.ToInt32(Console.ReadLine()); 
// return numberN;
// }
