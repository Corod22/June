// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число N");
int numberN=Convert.ToInt32(Console.ReadLine());
if (numberN%7==0) Console.WriteLine($"Число кратное 7");
if (numberN%23==0) Console.WriteLine($"Число кратное 23");
else Console.WriteLine($"Число не кратно 7 и 23");
Console.ReadKey();
