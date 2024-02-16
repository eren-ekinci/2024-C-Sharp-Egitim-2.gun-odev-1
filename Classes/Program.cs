using Classes.Entities;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();


Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Eren";
customer.LastName = "Ekinci";
customer.City = "İstanbul";

Customer customer2 = new Customer
{
	Id = 2,
	FirstName = "Deneme",
	LastName = "Deneme",
	City = "Ankara"
};

Console.WriteLine(customer2.FirstName);