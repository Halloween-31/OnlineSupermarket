using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.SupplierDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Supplier
    /// </summary>
    public class CreateEditSupplierRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }
        public string SupplierName { get; set; } = null!;        
        public string ContactInfo { get; set; } = null!;        
        public string Address { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
