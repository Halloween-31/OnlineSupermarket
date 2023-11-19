using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.SaleDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Sale
    /// </summary>
    public class CreateEditSaleRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }        
        public DateTime SaleDate { get; set; }        
        public decimal TotalAmount { get; set; }        
        public string PaymentMethod { get; set; } = null!;        
        public int? EmployeeId { get; set; }        
        public int CustomerId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
