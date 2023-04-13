//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Сколько чисел будет в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
fillArray(numbers);
Console.WriteLine("Мссив: ");
printArray(numbers);

int sum = 0;

for (int i = 0; i < numbers.Length; i += 2)
    sum = sum + numbers[i];

    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void fillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}

void printArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}