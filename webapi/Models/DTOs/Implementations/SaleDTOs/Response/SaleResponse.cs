using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.SaleDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Sale
    /// </summary>
    public class SaleResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public int? EmployeeId { get; set; }
        public int CustomerId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
