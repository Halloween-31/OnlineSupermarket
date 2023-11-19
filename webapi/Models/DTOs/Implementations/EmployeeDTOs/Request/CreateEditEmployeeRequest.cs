using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.EmployeeDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing Employee
    /// </summary>
    public class CreateEditEmployeeRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }
        public string FirstName { get; set; } = null!;        
        public string LastName { get; set; } = null!;        
        public DateTime DateOfBirth { get; set; }        
        public string Phone { get; set; } = null!;        
        public string Position { get; set; } = null!;        
        public double Salary { get; set; }        
        public int? StoreId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
