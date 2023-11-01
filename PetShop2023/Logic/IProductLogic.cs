using PetShop2023.Data;

namespace PetShop2023.Logic
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);
        public Product GetProductById(int productId);
	}
}
