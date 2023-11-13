using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilmez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyisim alanı boş geçilmez");
            RuleFor(x => x.City).NotEmpty().WithMessage("şehir alanı boş geçilmez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("isim için en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("soyisiim için en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("şehir için en az 3 karakter veri girişi yapınız");
        }
    }
}
