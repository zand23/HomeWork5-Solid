using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5_Solid.Task2
{
    internal class task2
    {
		public interface IProductRepository
		{
			List<string> GetProducts();
		}

		public class DatabaseProductRepository : IProductRepository
		{
			public List<string> GetProducts()
			{
				return new List<string>
				{
					"Product from Database 1",
					"Product from Database 2"
				};
			}
		}

		public class ApiProductRepository : IProductRepository
		{
			public List<string> GetProducts()
			{
				return new List<string>
				{
					"Product from API 1",
					"Product from API 2"
				};
			}
		}


		public class FileProductRepository : IProductRepository
		{
			public List<string> GetProducts()
			{
				return new List<string>
				{
					"Product from File 1",
					"Product from File 2"
				};
			}
		}


		public class ProductService
		{
			private readonly IProductRepository _repository;

			public ProductService(IProductRepository repository)
			{
				_repository = repository;
			}

			public void DisplayProducts()
			{
				var products = _repository.GetProducts();

				foreach (var product in products)
				{
					Console.WriteLine(product);
				}
			}
		}

	}
}
