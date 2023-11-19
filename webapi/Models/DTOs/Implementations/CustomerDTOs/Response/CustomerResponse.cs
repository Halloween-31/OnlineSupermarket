using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.CustomerDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Customer
    /// </summary>
    public class CustomerResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int? LoyaltyPoints { get; set; }
        public string? DestinationOfDelievery { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
