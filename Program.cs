// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//Console.WriteLine("Hello, World!");
Console.Write ("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i =0;i<array.Length;i++)
{
    array[i]=new Random().Next(-10,30); 
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int min = 0;
int max = 0;
for (int i=1;i<size; i++)  
{
    if (array[i] < min ) 
    min = array[i];
    if (array [i] > max)
     max = array[i];
}
//Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

