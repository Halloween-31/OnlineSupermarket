using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an instance of supplier
    /// </summary>
    public class Supplier: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a name of supplier
        /// </summary>
        public string SupplierName { get; set; } = null!;
        /// <summary>
        /// Represent a phone number of supplier
        /// </summary>
        public string ContactInfo { get; set; } = null!;
        /// <summary>
        /// Represent address of supplier
        /// </summary>
        public string Address { get; set; } = null!;
        /// <summary>
        /// Represent products which supplier can supplie
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        /// <summary>
        /// Represent spending supplier belog to
        /// </summary>
        public virtual ICollection<Spending> Spendings { get; set; } = new List<Spending>();

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
