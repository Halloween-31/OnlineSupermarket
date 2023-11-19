using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.EmployeeDTOs.Response
{
    /// <summary>
    /// Represent response (DTO) for Employee
    /// </summary>
    public class EmployeeResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
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
