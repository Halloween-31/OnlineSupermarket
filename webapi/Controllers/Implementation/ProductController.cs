using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.ProductDTOs.Request;
using webapi.Models.DTOs.Implementations.ProductDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Category
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericApiController<Product, CreateEditProductRequest, ProductResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public ProductController(IRepository<Product> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
