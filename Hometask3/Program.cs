// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));

int FindMax(int firstNumber, int secondNumber, int thirdNumber)
{
	int max = firstNumber;

	if (!IsLargeThen(firstNumber, secondNumber))
	{
		max = secondNumber;
	}

	if (IsLargeThen(thirdNumber, max))
	{
		max = thirdNumber;
	}

	return max;
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

bool IsLargeThen(int firstNumber, int secondNumber)
{
	return firstNumber > secondNumber;
}

bool IsEven(int number)
{
	return number % 2 == 0; // == - сравнение (результаты сравнения: true, false)
}

string GetNumbersAsLineUntil(int n)
{
	string result = string.Empty;

	for (int i = 1; i < n; i++)
	{
		if (IsEven(i))
		{
			result += $"{i} , ";
		}
	}

	return result;
}

int GetDigitFromNumber(int number, int digitPosition)
{
	string numberString = number.ToString();
	int move = numberString.Length - digitPosition;

	return int.Parse(numberString[numberString.Length - digitPosition].ToString());
}

int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}

int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}