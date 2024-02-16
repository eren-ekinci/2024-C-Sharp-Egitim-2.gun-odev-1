IWorker[] workers = [new Manager(), new Worker(), new Robot()];


foreach (var worker in workers)
{
	worker.Work();
}


IEat[] eats = [new Manager(), new Worker()];
foreach (var eat in eats)
{
	eat.Eat();
}







interface IWorker
{
	void Work();

}
interface IEat
{
	void Eat();
}
interface ISalary
{
	void GetSalary();
}

class Manager : IWorker, IEat, ISalary
{
	public void Eat()
	{
		Console.WriteLine("Yönetici Yemek Yedi.");
	}

	public void GetSalary()
	{
		Console.WriteLine("Yönetici Maaş Aldı.");
	}

	public void Work()
	{
		Console.WriteLine("Yönetici Çalıştı.");
	}
}
class Worker : IWorker, IEat, ISalary
{
	public void Eat()
	{
		Console.WriteLine("Çalışan Yemek Aldı.");
	}

	public void GetSalary()
	{
		Console.WriteLine("Çalışan Maaş Aldı.");
	}

	public void Work()
	{
		Console.WriteLine("Çalışan Çalıştı.");
	}
}
class Robot : IWorker
{
	public void Work()
	{
		Console.WriteLine("Robot Çalıştı.");
	}
}