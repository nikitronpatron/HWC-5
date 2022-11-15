//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

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

int[] myArray = CreateRandomArray(10, 1, 50);
ShowArray(myArray);

int min = myArray[0];
int max = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if(myArray[i] < min)
    {
        min = myArray[i];
    }
}

for (int i = 0; i < myArray.Length; i++)
{
    if(myArray[i] > max)
    {
        max = myArray[i];
    }
}

int variance = max - min;
Console.WriteLine(variance);