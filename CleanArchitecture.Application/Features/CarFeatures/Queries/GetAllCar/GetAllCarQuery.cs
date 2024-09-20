using CleanArchitecture.Domain.Entities;
using EntityFrameworkCorePagination.Nuget.Pagination;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar
{
    public sealed record class GetAllCarQuery(
        int pageNumer = 1,
        int pageSize = 10,
        string search = ""
        ) : IRequest<PaginationResult<Car>>;
    
}
