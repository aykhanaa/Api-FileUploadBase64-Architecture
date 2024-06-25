using FluentValidation;


namespace Service.DTOs.Admin.Countries
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public class SliderCreateDtoValidator : AbstractValidator<SliderCreateDto>
        {
            public SliderCreateDtoValidator()
            {
                RuleFor(x => x.Title).NotNull().WithMessage("Title PB101 is required");
                RuleFor(x => x.Description).NotEmpty().NotNull();
            }
        }
    }
}
