using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.SupplierDTOs.Request;
using webapi.Models.DTOs.Implementations.SupplierDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Supplier
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : GenericApiController<Supplier, CreateEditSupplierRequest, SupplierResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public SupplierController(IRepository<Supplier> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
