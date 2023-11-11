namespace webapi.Models.Interfaces
{
    /// <summary>
    /// Interface for representing and generalization Models in database
    /// </summary>    
    public interface IModel
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }
    }
}
