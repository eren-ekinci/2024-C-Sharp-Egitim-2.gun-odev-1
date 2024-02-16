//tek boyutlu diziler;

//string[] students = { "Eren", "Ali", "Veli" };

//foreach (var student in students)
//{
//	Console.WriteLine(student);
//}


//çift boyutlu diziler;

string[,] regions = new string[5, 3]
{
	{"İstanbul","İzmit","Balıkesir" },
	{"Ankara","Konya","Kırıkkale" },
	{"Antalya","Adana","Mersin"},
	{"Rize","Trabzon","Mersin" },
	{"İzmir","Muğla","Manisa"}
};
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
	for (int j = 0; j <= regions.GetUpperBound(1); j++)
	{
		Console.WriteLine(regions[i, j]);
	}
	Console.WriteLine("******************************");
}