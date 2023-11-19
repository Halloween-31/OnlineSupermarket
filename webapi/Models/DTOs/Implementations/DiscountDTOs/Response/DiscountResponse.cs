using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.DiscountDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Discount
    /// </summary>
    public class DiscountResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? ProductId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
