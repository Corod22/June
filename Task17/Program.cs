// 17. По двум заданным числам проверять является ли одно квадратом другого

int Number1 ()
{
Console.WriteLine("Введите первое число ");
int numN1=Convert.ToInt32(Console.ReadLine()); 
return numN1; 
}

int Number2 ()
{
Console.WriteLine("Введите второе число ");
int numN2=Convert.ToInt32(Console.ReadLine()); 
return numN2;
}

string ExaminationBumber (int num1, int num2)
{
    if (num1*num1==num2) return $"{num1} является квадратом числа {num2}";
    else if (num2*num2==num1) return $"{num2} является квадратом числа {num1}";
    return "Число не является квадратом другого";
}
int numberN1=Number1 ();
int numberN2=Number2 ();
string examinationBumber=ExaminationBumber(numberN1, numberN2);
Console.WriteLine(examinationBumber);
Console.ReadKey(); 