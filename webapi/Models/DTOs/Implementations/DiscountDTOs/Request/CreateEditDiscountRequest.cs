using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.DiscountDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Discount
    /// </summary>
    public class CreateEditDiscountRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }        
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
        public int? ProductId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
