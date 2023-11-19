using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.CategoryDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Category
    /// </summary>
    public class CreateEditCategoryRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set;}
        public string Name { get; set; } = null!;        
        public string? Description { get; set; }        
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
