// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);

}
Console.WriteLine("Ваш массив :");
for (int n = 0;n < array.Length; n++)
{
    Console.Write($"[{array[n]}] - ");
}
int CountEven = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        CountEven++;
    }
}
Console.WriteLine("");
Console.WriteLine($"Количество чётных чисел = {CountEven}");