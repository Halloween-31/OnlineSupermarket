using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.CategoryDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Category
    /// </summary>
    public class CategoryResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
