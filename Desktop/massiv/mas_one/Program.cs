// Задача 1: Задайте одномерный массив из 10 целых чисел 
// от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// Random random=new Random();
// int count=0;
// for(int i=0; i<10; i++)
// {
// array[i]= random.Next(1,101);
//    if (array[i] >= 20 && array[i] <= 90)
// {
//     count++;
// } 
// }
// Console.WriteLine();
// Console.WriteLine(count);

/////////////////////////////////////////////////
// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// namespace EvenNumbersInArray
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] array = new int[10]{6, 7, 19, 34, 3, 1, 4, 7, 9, 1};
//             int evenCount = 0;
//             foreach (int number in array)
//             {
// if (number % 2 == 0)
// {
//     evenCount++;
// }
//             }
//             Console.WriteLine($"Количество четных числе: {evenCount}");
//         }
//     }
// }

    
//  ................................................................       
    
//  Задача 3. Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}