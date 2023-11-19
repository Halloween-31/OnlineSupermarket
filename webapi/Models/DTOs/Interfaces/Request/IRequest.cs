namespace webapi.Models.DTOs.Interfaces.Request
{
    /// <summary>
    /// Represent an interface for request (DTO)
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int? Id { get; set; }
    }
}
