using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.SaleDTOs.Request;
using webapi.Models.DTOs.Implementations.SaleDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Sale
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : GenericApiController<Sale, CreateEditSaleRequest, SaleResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public SaleController(IRepository<Sale> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
