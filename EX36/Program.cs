//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 100, 999);
ShowArray(myArray);

//Для нечетных по индексу
int sumArrayIndex = 0;
for(int i = 0; i < myArray.Length; i++)
{
    if(i % 2 != 0)
    {
        sumArrayIndex += myArray[i];
    }
}
Console.WriteLine(sumArrayIndex);

//Для нечетных по визуальной составляющей
int sumArrayVisual = 0;
for(int i = 0; i < myArray.Length; i++)
{
    if(i % 2 == 0)
    {
        sumArrayVisual += myArray[i];
    }
}
Console.WriteLine(sumArrayVisual);