using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.SpendingDTOs.Request;
using webapi.Models.DTOs.Implementations.SpendingDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Spending
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SpendingController : GenericApiController<Spending, CreateEditSpendingRequest, SpendingResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public SpendingController(IRepository<Spending> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
