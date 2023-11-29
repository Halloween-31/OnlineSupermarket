using AutoMapper;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore.Metadata;
using webapi.Models.Interfaces;
using webapi.Controllers.Interfaces;
using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;
using webapi.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace webapi.Controllers.Generics
{
    /// <summary>
    /// Generic api controller for models with default implementation
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    [ApiController]    
    public abstract class GenericApiController<TEntity, TRequest, TResponse> : ControllerBase, IApiController<TEntity, TRequest, TResponse>
        where TEntity : class, IModel
        where TRequest : class, IRequest, new()
        where TResponse : class, IResponse, new()
    {
        private readonly IRepository<TEntity> repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to use depency injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        protected GenericApiController(IRepository<TEntity> repository, IMapper mapper)
        {
            this.repository = repository;
            this._mapper = mapper;
        }


        /// <summary>
        /// Method to get all elements of this model
        /// </summary>
        /// <returns>IEnumerable of models</returns>
        /// <inheritdoc/>
        [HttpGet]
        public virtual ActionResult<IEnumerable<TResponse>> GetAll()
        {
            var entities = repository.GetAll().ToList();

            // тут ерор
            //var responses = _mapper.Map<TResponse>(entities);
            //var responses = _mapper.Map<TResponse>(entities as List<TEntity>);
            // тут null
            //var responses = _mapper.Map<TResponse>(entities as List<IModel>);

            // wtf? так працює, ахахахах
            var responses = new List<TResponse>();
            foreach (var entity in entities)
            {
                responses.Add(_mapper.Map<TResponse>(entity));
            }
            return Ok(responses);
        }
        /// <summary>
        /// Get specific instance of models
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An object</returns>
        /// <inheritdoc/>
        [HttpGet("{id}")]
        public virtual ActionResult<TResponse> GetOne(int id)
        {
            var foundEntity = repository.GetById(id);
            if (foundEntity == null)
            {
                return NotFound();
            }
            var foundEntityResponse = _mapper.Map<TResponse>(foundEntity);
            return Ok(foundEntityResponse);
        }
        /// <summary>
        /// Create new instance of model
        /// </summary>
        /// <param name="toCreate"></param>
        /// <returns>Created object</returns>
        /// <inheritdoc/>
        [HttpPost]
        public virtual ActionResult<TResponse> Create([FromBody] TRequest toCreate)
        {
            var creating = _mapper.Map<TEntity>(toCreate);
            var created = repository.Add(creating);
            var createdResponse = _mapper.Map<TResponse>(created);
            return Ok(createdResponse);
        }
        /// <summary>
        /// Update an instance of model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="toUpdate"></param>
        /// <returns>Updated object</returns>
        /// <inheritdoc/>
        [HttpPatch("{id}")]
        public virtual ActionResult<TResponse> Update(int id, [FromBody] TRequest toUpdate)
        {
            var updating = _mapper.Map<TEntity>(toUpdate);
            updating.Id = id;
            var updated = repository.Update(updating);
            if (updated == null)
            {
                return NotFound();
            }
            var updatedResponse = _mapper.Map<TResponse>(updated);
            return Ok(updatedResponse);
        }
        /// <summary>
        /// Delete an instance of model
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted object</returns>
        /// <inheritdoc/>
        [HttpDelete("{id}")]
        public virtual ActionResult<TResponse> Delete(int id)
        {            
            var entity = repository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            repository.Delete(entity);
            var entityResponse = _mapper.Map<TResponse>(entity);
            return Ok(entityResponse);
        }        
    }
}
