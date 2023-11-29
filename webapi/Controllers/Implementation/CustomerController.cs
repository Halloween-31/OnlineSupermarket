using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Request;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Customer
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : GenericApiController<Customer, CreateEditCustomerRequest, CustomerResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public CustomerController(IRepository<Customer> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
