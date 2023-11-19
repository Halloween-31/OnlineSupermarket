using webapi.Models.DTOs.Interfaces.Request;
using webapi.Models.DTOs.Interfaces.Response;

namespace webapi.Models.DTOs.Implementations.StoreBranchDTOs.Response
{
    /// <summary>
    /// Represent a response (DTO) for StoreBranch
    /// </summary>
    public class StoreBranchResponse : IResponse
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Info { get; set; } = null!;
        public DateTime OpeningDate { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
