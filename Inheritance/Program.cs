
Person[] persons = new Person[]
{
	new Person { FirstName="Eren"},
	new Customer { FirstName="Deneme Müşteri"},
	new Student{FirstName="Deneme Öğrenci" }
};

foreach (Person person in persons)
{
	Console.WriteLine(person.FirstName);
}


class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

class Customer : Person
{
	public string City { get; set; }
}

class Student : Person
{
	public string Departman { get; set; }
}