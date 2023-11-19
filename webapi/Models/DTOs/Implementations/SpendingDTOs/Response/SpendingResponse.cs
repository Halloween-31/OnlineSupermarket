using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.SpendingDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for Spending
    /// </summary>
    public class SpendingResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public DateTime SpendingDate { get; set; }
        public decimal Amount { get; set; }
        public int Price { get; set; }
        public string Description { get; set; } = null!;
        public int? EmployeeId { get; set; }
        public int? SupplierId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }    
}
