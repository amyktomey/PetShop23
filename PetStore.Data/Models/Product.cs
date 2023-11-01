namespace PetShop2023.Data
{
    public class Product
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
		public int ProductId { get; internal set; }
	}
}
