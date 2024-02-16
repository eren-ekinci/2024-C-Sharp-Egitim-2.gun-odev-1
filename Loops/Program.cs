﻿
if (IsPrimeNumber(7))
{
	Console.WriteLine("This is a prime number");
}
else
{
	Console.WriteLine("This is not a prime number");
}


static bool IsPrimeNumber(int number)
{
	bool result = true;
	for (int i = 2; i < number; i++)
	{
		if (number % i == 0)
		{
			result = false;
			break;
		}
	}
	return result;

}



static void ForLoop()
{
	for (int i = 2; i <= 100; i = i + 2)
	{
		Console.WriteLine(i);
	}
	Console.WriteLine("Finished!");
}

static void WhileLoop()
{
	int number = 100;
	while (number >= 0)
	{
		Console.WriteLine(number);
		number--;

	}
}

static void DoWhileLoop()
{
	int number = 10;
	do
	{
		Console.WriteLine(number);
		number--;
	} while (number >= 11);
}

static void ForEachLoop()
{
	string[] students = { "Eren", "Ali", "Veli" };

	foreach (var student in students)
	{
		Console.WriteLine(student);
	}
}