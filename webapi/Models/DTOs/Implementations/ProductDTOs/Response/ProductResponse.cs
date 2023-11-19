using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.ProductDTOs.Response
{
    /// <summary>
    /// Represent response (DTO) for Product
    /// </summary>
    public class ProductResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
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
