using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.StoreBranchDTOs.Request;
using webapi.Models.DTOs.Implementations.StoreBranchDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model StoreBranch
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StoreBranchController : GenericApiController<StoreBranch, CreateEditStoreBranchRequest, StoreBranchResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public StoreBranchController(IRepository<StoreBranch> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
