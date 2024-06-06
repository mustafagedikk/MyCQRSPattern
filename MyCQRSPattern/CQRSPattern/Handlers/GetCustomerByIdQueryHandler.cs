using AutoMapper;
using MyCQRSPattern.CQRSPattern.Queries;
using MyCQRSPattern.CQRSPattern.Result;
using MyCQRSPattern.DataAcces.Context;

namespace MyCQRSPattern.CQRSPattern.Handlers
{
    public class GetCustomerByIdQueryHandler
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public GetCustomerByIdQueryHandler(IMapper mapper,Context context)
        {
            _mapper = mapper;
            _context = context;
        }


        public GetCustomerByIdQureyResult Handle(GetCustomerByIdQuery query)
        {
            var customer=_context.Customers.FirstOrDefault(x=>x.CustomerId==query.Id);
            var mappedCustomer=_mapper.Map<GetCustomerByIdQureyResult>(customer);
            return mappedCustomer;
        }
    }
}
