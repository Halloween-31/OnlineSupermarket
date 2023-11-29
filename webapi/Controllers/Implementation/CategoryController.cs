using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Request;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Response;
using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Category
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericApiController<Category, CreateEditCategoryRequest, CategoryResponse>
    { 
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public CategoryController(IRepository<Category> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
