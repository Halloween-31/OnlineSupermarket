using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers.Generics;
using webapi.Models.DTOs.Implementations.EmployeeDTOs.Request;
using webapi.Models.DTOs.Implementations.EmployeeDTOs.Response;
using webapi.Models.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Controllers.Implementation
{
    /// <summary>
    /// Controller to work with model Employee
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericApiController<Employee, CreateEditEmployeeRequest, EmployeeResponse>
    {
        /// <summary>
        /// Constructor to use Depedency Injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public EmployeeController(IRepository<Employee> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
