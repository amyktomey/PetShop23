using Microsoft.Extensions.DependencyInjection;
using PetShop2023.Logic;
using PetShop2023.Data;
using System.Text.Json;
using PetStore.Data;


// var dogLeash = new DogLeash();
var dogLeash = new Product();

var services = CreateServiceCollection();

var productLogic = services.GetService<IProductLogic>();

string userInput = DisplayMenuAndGetInput();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
		Console.WriteLine("Please add a Product in JSON format");
		var userInputAsJson = Console.ReadLine();
		var _dogLeash = JsonSerializer.Deserialize<Product>(userInputAsJson);
		productLogic.AddProduct(product: dogLeash);
	}
    if (userInput == "2")
    {
		Console.Write("What is the id of the product you would like to view? ");
		var id = int.Parse(Console.ReadLine());
		var product = productLogic.GetProductById(id);
		Console.WriteLine(JsonSerializer.Serialize(product));
		Console.WriteLine();
	}
 }
static string DisplayMenuAndGetInput()
{
	Console.WriteLine("Press 1 to add a product");
	Console.WriteLine("Press 2 to view a product");
	Console.WriteLine("Type 'exit' to quit");

	return Console.ReadLine();
}

static IServiceProvider CreateServiceCollection()
{
	return new ServiceCollection()
		.AddTransient<IProductLogic, ProductLogic>()
		.AddTransient<IProductRepository, ProductRepository>()
		.BuildServiceProvider();
}
