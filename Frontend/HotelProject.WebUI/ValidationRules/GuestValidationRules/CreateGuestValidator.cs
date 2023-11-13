using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilmez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyisim alanı boş geçilmez");
            RuleFor(x => x.City).NotEmpty().WithMessage("şehir alanı boş geçilmez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("isim için en az 3 karakter veri girişi yapınız");
        }
    }
}
