// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int Number ()
{
Console.WriteLine("Введите день недели ");
int numberN=Convert.ToInt32(Console.ReadLine()); 
return numberN;
}

string  WeekDay(int num)
{
    if (num >0 && num <8)
    {
     if (num <6) return "Рабочий день";
     else if (num > 5) return "Выходной день";
    }
    return "Введине корректный день недели";
}


int numberN=Number();
string аindingout = WeekDay(numberN);
Console.WriteLine(аindingout);
Console.ReadKey(); 