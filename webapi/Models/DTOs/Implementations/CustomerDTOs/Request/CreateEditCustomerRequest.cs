using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.CustomerDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Customer
    /// </summary>
    public class CreateEditCustomerRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }
        public string FirstName { get; set; } = null!;        
        public string LastName { get; set; } = null!;        
        public string ContactInfo { get; set; } = null!;        
        public string Address { get; set; } = null!;        
        public int? LoyaltyPoints { get; set; }        
        public string? DestinationOfDelievery { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
