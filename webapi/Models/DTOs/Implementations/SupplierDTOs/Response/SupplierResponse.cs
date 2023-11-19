using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.SupplierDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Supplier
    /// </summary>
    public class SupplierResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public string Address { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
