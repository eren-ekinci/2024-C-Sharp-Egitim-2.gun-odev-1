

//Add();

//Console.WriteLine(Add2(5, 10));

//int number1 = 20;
//int number2 = 100;
//var result = Add3(number1, number2);
//Console.WriteLine(result);


Console.WriteLine(Add4(1, 5, 6, 5, 8, 10));

static void Add()
{
	Console.WriteLine("Added");
}

static int Add2(int number1, int number2)
{
	return number1 + number2;
}

static int Add3(int number1, int number2)
{
	number1 = 30;
	return (number1 + number2);
}

static int Add4(params int[] numbers)
{
	return numbers.Sum();
}