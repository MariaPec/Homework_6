//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int Prompt (string message)
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}


void PrintArray(int[] PArray)
{
    for (int j = 0; j < PArray.Length; j++)
    {
        Console.Write($"{PArray[j]} ");
    }
}


int M = Prompt("введите число, равное желаемому количеству проверок на положительность числа: ");
int number;
int[]array = new int [M];

for(int j = 0; j < M; j++)
{
    number = Prompt($"Введите число {1+j}");
    array[j] = number;
}
Console.WriteLine($"Вы ввели");
PrintArray(array);

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++; 
    }
}
Console.WriteLine($"Введено {count} положительных чисел");