using FluentValidation;

namespace BookingApi.Booking;

public class BookingValidator: AbstractValidator<CreateBookingDto>
{
    public BookingValidator()
    {
        RuleFor(x => x.StartDate)
            .NotEmpty()
            .WithMessage("Booking date is required.");
        RuleFor(x => x.EndDate)
            .NotEmpty()
            .WithMessage("Booking date is required.")
            .Must(date => date > DateTime.UtcNow)
            .WithMessage("Booking date must be in the future.");
        RuleFor(x => x.WorksapceId)
            .NotEmpty()
            .Must(id => id > 0)
            .WithMessage("Workspace ID must be a positive integer.");
    }
}
