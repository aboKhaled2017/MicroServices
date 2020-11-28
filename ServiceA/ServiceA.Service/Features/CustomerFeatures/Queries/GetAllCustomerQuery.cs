using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceA.Domain.Entities;
using ServiceA.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceA.Service.Features.CustomerFeatures.Queries
{
    public class GetAllCustomerQuery : IRequest<IEnumerable<Customer>>
    {

        public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IEnumerable<Customer>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllCustomerQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
            {
                var customerList = await _context.Customers.ToListAsync();
                if (customerList == null)
                {
                    return null;
                }
                return customerList.AsReadOnly();
            }
        }
    }
}
