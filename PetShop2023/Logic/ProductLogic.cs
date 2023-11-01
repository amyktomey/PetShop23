using PetShop2023.Data;
using PetStore.Data;
using PetShop2023.Validators;

namespace PetShop2023.Logic
{
	internal class ProductLogic : IProductLogic
	{
		private readonly IProductRepository _productRepo;

		public ProductLogic(IProductRepository productRepository)
		{
			_productRepo = productRepository;
		}

		public void AddProduct(Product product)
		{
			var validator = new ProductValidator();
			if (validator.Validate(product).IsValid)
			{
				_productRepo.AddProduct(product);
			}
		}

        Product IProductLogic.GetProductById(int productId)
        {
            return GetProductById(productId);
        }

        public List<Product> GetAllProducts()
		{
			return _productRepo.GetAllProducts();
		}

        Product GetProductById(int id)
		{
			return _productRepo.GetProductById(id);
		}
	}
}
