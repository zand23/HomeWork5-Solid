namespace HomeWork5_Solid.Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// ----------- دریافت منبع داده از کاربر -----------
			Console.WriteLine("Enter source (Database / API / File):");
			string source = Console.ReadLine()?.Trim();

			// ----------- ساخت ServiceCollection و ثبت سرویس‌ها -----------
			var services = new ServiceCollection();

			switch (source)
			{
				case "Database":
					services.AddTransient<IProductRepository, DatabaseProductRepository>();
					break;
				case "API":
					services.AddTransient<IProductRepository, ApiProductRepository>();
					break;
				case "File":
					services.AddTransient<IProductRepository, FileProductRepository>();
					break;
				default:
					Console.WriteLine("Invalid source, defaulting to Database.");
					services.AddTransient<IProductRepository, DatabaseProductRepository>();
					break;
			}

			// ثبت ProductService
			services.AddTransient<ProductService>();

			// ----------- ساخت ServiceProvider و گرفتن سرویس -----------
			var provider = services.BuildServiceProvider();
			var productService = provider.GetRequiredService<ProductService>();

			// نمایش محصولات
			productService.DisplayProducts();

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}
	}

	// ---------------- اینترفیس ----------------
	public interface IProductRepository
	{
		System.Collections.Generic.List<string> GetProducts();
	}

	// ---------------- کلاس‌های Repository ----------------
	public class DatabaseProductRepository : IProductRepository
	{
		public System.Collections.Generic.List<string> GetProducts()
		{
			return new System.Collections.Generic.List<string>
			{
				"DB Product 1",
				"DB Product 2"
			};
		}
	}

	public class ApiProductRepository : IProductRepository
	{
		public System.Collections.Generic.List<string> GetProducts()
		{
			return new System.Collections.Generic.List<string>
			{
				"API Product 1",
				"API Product 2"
			};
		}
	}

	public class FileProductRepository : IProductRepository
	{
		public System.Collections.Generic.List<string> GetProducts()
		{
			return new System.Collections.Generic.List<string>
			{
				"File Product 1",
				"File Product 2"
			};
		}
	}

	// ---------------- ProductService ----------------
	public class ProductService
	{
		private readonly IProductRepository _repository;

		public ProductService(IProductRepository repository)
		{
			_repository = repository;
		}

		public void DisplayProducts()
		{
			Console.WriteLine("\nProducts:");
			foreach (var product in _repository.GetProducts())
			{
				Console.WriteLine($"- {product}");
			}
		}
	}
}