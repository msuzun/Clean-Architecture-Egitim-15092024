﻿using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecute.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecute.Persistance.Services
{
    public sealed class CarService : ICarService
    {
        private readonly AppDbContext _context;
        public CarService(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(CreateCarCommand reuest, CancellationToken cancellationToken)
        {
            Car car = new()
            {
                Name = reuest.Name,
                Model = reuest.Model,
                EnginePower = reuest.EnginePower
            };
            await _context.Set<Car>().AddAsync(car, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
