///Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void zadacha34()
{
    Random random = new Random();
    int size = random.Next(5,11);
    int []array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"В массиве {count} четных чисел ");

}   

///Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha36()
{
    
    Random random = new Random();
    int size = random.Next(5,11);
    int []array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 1; i<array.Length; i+=2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позиция равна :   {sum}"  );
}
void zadacha38()
{
    ///Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    Random random = new Random();
    int size = random.Next(5,11);
    double []array = new double[size];
    FillArrayDouble(array, 1000, 100000);
    PrintArrayDouble(array);

    double max = array[0];
    double min = array[0];
    for (int i = 1; i<array.Length; i+=2)
    {
        if(array[i] > max) max =array[i];
        else if (array[i] < min) min =array[i];
    }
    Console.WriteLine($"Разница между минимальным элементом {min} и максимальным {max} равна {max-min}");

}

void FillArray(int[] array, int startNumber= -10, int finishNumber =10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i<array.Length; i++)
    {
        array[i] =  random.Next( startNumber, finishNumber );
    }
}
void FillArrayDouble(double[] array, int startNumber= -10, int finishNumber =10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i<array.Length; i++)
    {
        array[i] =  Math.Round(random.NextDouble()*10-5, 2);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
void PrintArrayDouble(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (double i = 0; i<array.Length; i++)
    {
        Console.Write(array [i]+"\t");
    }
    Console.WriteLine();
}
//zadacha34();
//Zadacha36();
zadacha38();


