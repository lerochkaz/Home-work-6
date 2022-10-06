// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0
// 7
// 8
// -2
// -2 -> 2
// 5
// 1
// -7
// 567
// 89
// 223-> 3

int RequestQuantityInput()
{
    Console.Write("Введите количество чисел: ");
    int quantityInput = int.Parse(Console.ReadLine()!);
    return quantityInput;
}

int[] InputNumbersInArray(int quantityInput)
{
    int[] arrayNumbers = new int[quantityInput];
    Console.WriteLine("Введите числа через ENTER: ");
    for (int i = 0; i < quantityInput; i++)
    {
        arrayNumbers[i] = int.Parse(Console.ReadLine()!);
    }
    return arrayNumbers;
}

int CounterPositivNumber(int[] arrayNumbers)
{
    int size = arrayNumbers.Length;
    int counter = 0;
    for (int j = 0; j < size; j++)
    {
        if (arrayNumbers[j] > 0) counter++;
    }
    return counter;
}

void PrintResponse(int counter)
{
    Console.Write($"Пользователь ввел количество цифр больше нуля: {counter}");
}

int NumberOfDigits = RequestQuantityInput();
int[] array = InputNumbersInArray(NumberOfDigits);
int result = CounterPositivNumber(array);
PrintResponse(result);
