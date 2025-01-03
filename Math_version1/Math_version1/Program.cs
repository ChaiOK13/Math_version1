﻿

PrintYellow("Программа для анализа функции!  y= √(1+2x^2), x<=0");

while (true)  
{
    MyProgramm(); 
}





void MyProgramm()
{
    PrintGreen("Введите x минимальный(значение <= 0): "); 

    double xMin = GetDouble();  
    


    PrintGreen("Введите x максимальный(значение <= 0): ");

    double xMax = GetDouble();

    PrintGreen("Введите шаг функции");

    double xStep = GetDouble();

   

    Myfunction(xMin, xMax, xStep); // когда  у  нас  есть  все данные  дадим их отдельному методу 
}

void Myfunction(double xMin, double xMax, double xStep)
{
    // валидация  входных параметров 
    if (xMin > xMax)
    {
        PrintRed("x минимальная больше чем x максимальная");
        return; // выход из функции  дострочно
    }

    if (xStep == 0)
    {
        PrintRed("Шаг равен нулю");
        return;
    }

    if (xStep < 0)
    {
        PrintRed("Шаг меньше нуля");
        return;
    }

    if (xMin > 0 || xMax > 0)
    {
        PrintRed("x больше 0");
        return;
    }

    PrintYellow("_____Ответ____");
    /// переберем функцию 
    for (double i = xMin; i <= xMax; i += xStep)
    {
        double y = GetValueFunction(i);
        PrintYellow($"x={i}: y={y}"); // Ответ 
    }
    PrintYellow($"Пересечение функции с осью X В точке: {GetValueFunction(0)}");
}


double GetValueFunction(double x)
{
    return Math.Sqrt(1 + 2 * Math.Pow(x, 2)); // формула
}
void PrintGreen(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Green; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}

void PrintYellow(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Yellow; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}


void PrintRed(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомнит текущий цвет
    Console.ForegroundColor = ConsoleColor.Red; // поменяем  на  зеленый цвет
    Console.WriteLine(message);  //  выведем  сообщение 
    Console.ForegroundColor = color; // вернем  базовый цвет
}



double GetDouble()
{
    try
    {
        string temp = Console.ReadLine();
        return Convert.ToDouble(temp);
    }
    catch
    {
        PrintRed("Не верный ввод, введите число");
        return GetDouble();
    }
}