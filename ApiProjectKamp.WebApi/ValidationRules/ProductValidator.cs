using System.Data;
using ApiProjectKamp.WebApi.Entities;
using FluentValidation;

namespace ApiProjectKamp.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçemezsiniz");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Ürün adını en az 2 karakter olmalı");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Ürün adını en fazla 50 karakter olmalı");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, girdiğiniz değeri kontrol edin!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");

        }
    }
}