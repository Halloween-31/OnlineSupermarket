using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore.Metadata;
using webapi.Models.Interfaces;
using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Controllers.Interfaces
{
    /// <summary>
    /// Interface for my api controllers to work with models
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public interface IApiController<TEntity, TRequest, TResponse>
        where TEntity : class, IModel
        where TRequest : class, IRequest, new()
        where TResponse : class, IResponse, new()
    {
        /// <summary>
        /// Method to get all elements of this model
        /// </summary>
        /// <returns>IEnumerable of models</returns>
        [HttpGet]
        public ActionResult<IEnumerable<TResponse>> GetAll();
        /// <summary>
        /// Get specific instance of models
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An object</returns>
        [HttpGet("{id}")]
        public ActionResult<TResponse> GetOne(int id);
        /// <summary>
        /// Create new instance of model
        /// </summary>
        /// <param name="toCreate"></param>
        /// <returns>Created object</returns>
        [HttpPost]
        public ActionResult<TResponse> Create([FromBody] TRequest toCreate);
        /// <summary>
        /// Update an instance of model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="toUpdate"></param>
        /// <returns>Updated object</returns>
        [HttpPatch("{id}")]
        public ActionResult<TResponse> Update(int id, [FromBody] TRequest toUpdate);
        /// <summary>
        /// Delete an instance of model
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted object</returns>
        [HttpDelete("{id}")]
        public ActionResult<TResponse> Delete(int id);
    }
}
