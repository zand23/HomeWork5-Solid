// See https://aka.ms/new-console-template for more information
using static HomeWork5_Solid.Task2.task2;

Console.WriteLine("Hello, World!");

	static void Main(string[] args)
	{
		IProductRepository repository = new DatabaseProductRepository();
		
		// new ApiProductRepository();
		// new FileProductRepository();

		var productService = new ProductService(repository);
		productService.DisplayProducts();
	}
