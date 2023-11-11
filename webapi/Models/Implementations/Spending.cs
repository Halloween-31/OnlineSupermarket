using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Repressent an instance of spending
    /// </summary>
    public class Spending: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a date when spending was done
        /// </summary>
        public DateTime SpendingDate { get; set; }
        /// <summary>
        /// Represent amount of product it was spent
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Represent spent money
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Represent a description of spending
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Represent an employee who did spending
        /// </summary>
        public int? EmployeeId { get; set; }
        /// <summary>
        /// Represent a supplier, who supplie goods
        /// </summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// The actual employee
        /// </summary>
        public virtual Employee? Employee { get; set; } = null!;
        /// <summary>
        /// Represent product, that were bought
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        /// <summary>
        /// The actual supplier
        /// </summary>
        public virtual Supplier? Supplier { get; set; } = null!;

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
