using webapi.Models.DTOs.Interfaces.Request;

namespace webapi.Models.DTOs.Implementations.StoreBranchDTOs.Request
{
    /// <summary>
    /// Represent a request (DTO) for creating or editing StoreBranch
    /// </summary>
    public class CreateEditStoreBranchRequest : IRequest
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int? Id { get; set; }
        public string Name { get; set; } = null!;        
        public string Location { get; set; } = null!;
        public string Info { get; set; } = null!;        
        public DateTime OpeningDate { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
