using FluentValidation;
using PetShop2023.Data;

namespace PetShop2023.Validators
{
	internal class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			// RuleFor(x => x.Name).NotEmpty();
			// RuleFor(x => x.Description).MinimumLength(10).When(x => !string.IsNullOrEmpty(x.Description));
			RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0);
			RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
		}
	}
}
