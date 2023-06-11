// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-50; 50]
}

int CountNum(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0)
            count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чисел, которые больше нуля в массиве: {CountNum(array)}");
        


