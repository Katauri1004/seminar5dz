//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[10] {5.13, 6.75, 10.34, 1.2, 4.85, 5.76, 17.34, 19.23, 98.54, 33.4};

Console.WriteLine("Ваш массив :");
for (int n = 0;n < array.Length; n++)
{   

    Console.Write($"[{array[n]} ]");
}
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    else if (array[j] < min)
    {
        min = array[j];
    }     
}
double result = max-min;

Console.WriteLine ("");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {result}");