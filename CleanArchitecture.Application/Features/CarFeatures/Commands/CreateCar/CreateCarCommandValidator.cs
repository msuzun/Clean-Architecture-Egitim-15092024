﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(p=>p.Name).NotEmpty().WithMessage("Araç adı boş olamaz");
        RuleFor(p=>p.Name).NotNull().WithMessage("Araç adı boş olamaz");
        RuleFor(p=>p.Name).MinimumLength(3).WithMessage("Araç adı en az 3 karakter olmalıdır!");
        RuleFor(p => p.Model).NotEmpty().WithMessage("Araç Modeli boş olamaz");
        RuleFor(p => p.Model).NotNull().WithMessage("Araç Modeli boş olamaz");
        RuleFor(p => p.Model).MinimumLength(3).WithMessage("Araç Modeli en az 3 karakter olmalıdır!");
        RuleFor(p => p.EnginePower).NotEmpty().WithMessage("Araç Motor gücü boş olamaz");
        RuleFor(p => p.EnginePower).NotNull().WithMessage("Araç Motor gücü boş olamaz");
        RuleFor(p => int.Parse(p.EnginePower)).GreaterThan(0).WithMessage("Araç Motor gücü 0'dan büyük olmalıdır!");
    }
}
