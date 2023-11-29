using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.DiscountDTOs.Request;
using webapi.Models.DTOs.Implementations.DiscountDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Discount
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : GenericApiController<Discount, CreateEditDiscountRequest, DiscountResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public DiscountController(IRepository<Discount> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
