using System.Diagnostics.Contracts;
using System.Xml.Serialization;

Main();

void Main()
{
    //Task1();
    // Task2();
    //Task3();
}

void Task1()
{
    while (true)
    {
        string textPrint = Console.ReadLine();
        if (int.TryParse(textPrint, out int result))
        {
            int checkNumber = 0;
            while (result > 0)
            {
                checkNumber += result % 10;
                result /= 10;
            }
            if (checkNumber % 2 == 0) break;
        }
        else
            if (textPrint == "q") break;
    }
}
void Task2()
{
    //Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    int[] array = new int[Convert.ToInt32(Console.ReadLine())];

    GeneretArray(array, 100, 1000);
    PrintArray(array);
    PrintEvenDigit(countEven(array));





}
void Task3()
{
    //Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    GeneretArray(array, 100, 1000);
    PrintArray(array);

    System.Console.WriteLine("\nПервый способ");
    ReverseArray1(array);
    PrintArray(array);
    System.Console.WriteLine("\nВторой способ");
    ReverseArray2(array);
    PrintArray(array);
}

void GeneretArray(int[] myArray, int leftDigit, int rightDigit)
{
    Random random = new Random();
    for (int i = 0; i < myArray.Length; i++)
        myArray[i] = random.Next(leftDigit, rightDigit);
}

void PrintArray(int[] arrayPrint) => System.Console.WriteLine("[" + string.Join(",", arrayPrint) + "]");

int countEven(int[] array)
{
    int countNeedDigit = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) countNeedDigit++;
    return countNeedDigit;
}

void PrintEvenDigit(int countDigit) => System.Console.WriteLine(countDigit);

void ReverseArray1(int[] array) => Array.Reverse(array);

void ReverseArray2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tempDigit = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tempDigit;
    }
}

