using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Ürün Adı
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$").WithMessage("Ürün adı sadece harflerden oluşabilir.");

            //Ürün Fiyatı
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez.")
                .Must(BeANumber).WithMessage("Ürün fiyatı sadece nümerik ifade içerebilir.");

        }

        private bool BeANumber(double productPrice)
        {
            return double.TryParse(productPrice.ToString(), out _);
        }
    }  
}
