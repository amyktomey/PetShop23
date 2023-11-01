using PetShop2023.Data;

namespace PetStore.Data
{
	public class ProductRepository : IProductRepository
	{
		private readonly ProductContext _productContext;

		public ProductRepository(ProductContext productContext)
		{
			_productContext = productContext;
		}
        public void AddProduct(Product product)
        {
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
