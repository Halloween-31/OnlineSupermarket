using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Repressent an instance of discount
    /// </summary>
    public class Discount: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a name of discount
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Represent a description of discount
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Represent a date when discount starts
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Represent a date when discount ends
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Represent a discounted product
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// The actual product
        /// </summary>
        public virtual Product Product { get; set; } = null!;
        /// <summary>
        /// Represent customers which have this discount
        /// </summary>
        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

        /// <inheritdoc/>
        public override string ToString()
        {
            Type type = this.GetType();
            string res = "";
            res += type.ToString() + ":\n\t";
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    res += propertyInfo.Name + ": ";
                    res += propertyInfo.GetValue(this, null) + "\n\t";
                }
            }
            res += "\n\n\n";
            return res;
        }
    }
}
