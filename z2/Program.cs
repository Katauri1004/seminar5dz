//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);

}
Console.WriteLine("Ваш массив :");
for (int n = 0;n < array.Length; n++)
{   

    Console.Write($"[{array[n]} ]");
}
int sumOdd = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j %2 == 1)
    {
        sumOdd=sumOdd + array[j];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма значений элементов на нечётных позициях = {sumOdd}");