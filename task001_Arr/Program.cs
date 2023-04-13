//Программа, которая покажет количество чётных чисел в массиве.

Console.Write("Сколько чисел будет в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
fillArray(numbers);
Console.WriteLine("Массив: ");
printArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них чётные");

void fillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
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