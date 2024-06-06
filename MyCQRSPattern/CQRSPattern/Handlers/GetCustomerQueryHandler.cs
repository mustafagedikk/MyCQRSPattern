using AutoMapper;
using MyCQRSPattern.CQRSPattern.Result;
using MyCQRSPattern.DataAcces.Context;

namespace MyCQRSPattern.CQRSPattern.Handlers
{
    public class GetCustomerQueryHandler
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public GetCustomerQueryHandler(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetCustomerQueryResult> Handle()
        {
            var values=_context.Customers.ToList();
            return _mapper.Map<List<GetCustomerQueryResult>>(values);
          
        }
    }
}
