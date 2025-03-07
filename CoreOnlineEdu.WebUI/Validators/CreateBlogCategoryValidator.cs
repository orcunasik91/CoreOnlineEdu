using CoreOnlineEdu.WebUI.Dtos.BlogCategoryDtos;
using FluentValidation;

namespace CoreOnlineEdu.WebUI.Validators;
public class CreateBlogCategoryValidator : AbstractValidator<CreateBlogCategoryDto>
{
    public CreateBlogCategoryValidator()
    {
        RuleFor(bc => bc.CategoryName)
            .NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!")
            .MaximumLength(60).WithMessage("Kategori Adı 60 Karakterden Fazla Olamaz!")
            .MinimumLength(2).WithMessage("Kategori Adı 2 Karakterden Az Olamaz!");
    }
}