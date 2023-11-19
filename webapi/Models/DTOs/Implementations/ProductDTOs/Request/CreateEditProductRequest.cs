using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.ProductDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Product
    /// </summary>
    public class CreateEditProductRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }
        public string ProductName { get; set; } = null!;  
        public string Description { get; set; } = null!;
        public long Count { get; set; }
        public decimal Price { get; set; }        
        public int CategoryId { get; set; }        
        public int? SpendingId { get; set; }        
        public int? SupplierId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
