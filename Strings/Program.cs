
string sentence = "My name is Eren Ekinci";
var result = sentence.Length;
var result2 = sentence.Clone();

sentence = "My name is deneme deneme";

bool result3 = sentence.EndsWith("i");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name"); //bir metnin içeresinde bir ifadeyi aramak için. yok ise -1 döner.
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" "); // sondan başlayarak arama  yapar

var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2, 4);

Console.WriteLine(result13);




static void Intro()
{
	string City = "İstanbul";

	//Console.WriteLine(City[0]);

	foreach (var item in City)
	{
		Console.WriteLine(item);
	}

	string City2 = "Ankara";


	Console.WriteLine($"{City} {City2}");
}
