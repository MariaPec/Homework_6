// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Prompt (string message)
{
    Console.WriteLine(message);
    double param = double.Parse(Console.ReadLine());
    return param;
}

double k1 = Prompt("Введите k1 ");
double b1 = Prompt("Введите b1 ");
double k2 = Prompt("Введите k2 ");
double b2 = Prompt("Введите b2 ");

double x;
double y;

if (k1 == k2)
{
    if(b1 == b2)
    {
    Console.WriteLine($"Прямые совпадают");
    }
    else  Console.WriteLine($"Прямые параллельны");
}
else
{
x = (b2 - b1) / (k1 - k2);
y = k2 * x + b2;  
Console.WriteLine($"Прямые пересекаются в точке [{Math.Round(x, 1)}, {Math.Round(y, 1)}]");
}



