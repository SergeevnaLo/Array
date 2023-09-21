//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];

Array(num);
Console.WriteLine("Числа в массиве: ");
PrintArray(num);

int count = 0;

for (int s = 0; s < num.Length; s++)
    if (num[s] % 2 == 0)
        count++;

Console.WriteLine($"Всего {num.Length} чисел, {count} из них чётные");

void Array(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива: ");
int sz = Convert.ToInt32(Console.ReadLine());
int[] number = new int[sz];

FillArrayRandomNumbers(number);
Console.WriteLine("Массив чисел: ");
PrintArrayRandom(number);

int sum = 0;

for (int k = 0; k < number.Length; k += 2)
    sum += number[k];

Console.WriteLine($"Всего {number.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(1, 10);
    }
}
void PrintArrayRandom(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.WriteLine();
}
// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int td = Convert.ToInt32(Console.ReadLine());
double[] numb = new double[td];

ArrayRandomNumbers(numb);
Console.WriteLine("Массив чисел: ");
PrintArrayRandomNumbers(numb);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int r = 0; r < numb.Length; r++)
{
    if (numb[r] > max)
    {
        max = numb[r];
    }
    if (numb[r] < min)
    {
        min = numb[r];
    }
}

Console.WriteLine($"Всего {numb.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void ArrayRandomNumbers(double[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArrayRandomNumbers(double[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i] + " ");
    }
    Console.WriteLine();
}