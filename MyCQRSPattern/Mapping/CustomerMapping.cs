using AutoMapper;
using MyCQRSPattern.CQRSPattern.Result;
using MyCQRSPattern.DataAcces.Entities;

namespace MyCQRSPattern.Mapping
{
    public class CustomerMapping:Profile
    {
        public CustomerMapping()
        {
            CreateMap<GetCustomerQueryResult, Customer>().ReverseMap();
            CreateMap<GetCustomerByIdQureyResult, Customer>().ReverseMap();

        }
    }
}
