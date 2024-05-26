using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //Müşteri Adı
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri adı boş geçilemez.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$").WithMessage("Müşteri adı sadece harflerden oluşabilir.");

            //Müşteri Soyadı 
            RuleFor(x => x.CustomerSurname).NotEmpty().WithMessage("Müşteri soyadı boş geçilemez.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$").WithMessage("Müşteri soyadı sadece harflerden oluşabilir.");

            //Müşteri Maili 
            RuleFor(x => x.CustomerEmail).NotEmpty().WithMessage("Müşteri maili boş geçilemez.")
                .Matches(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").WithMessage("Geçerli bir e-posta adresi giriniz.");

            //Müşteri Telefonu 
            RuleFor(x => x.CustomerPhone).NotEmpty().WithMessage("Müşteri telefonu boş geçilemez.")
                 .Matches(@"^\d{10}$").WithMessage("Geçerli bir telefon numarası giriniz (örn. 5551234567).");

            //Müşteri Adresi 
            RuleFor(x => x.CustomerAdress).NotEmpty().WithMessage("Müşteri adresi boş geçilemez.");

        }
    }
}
