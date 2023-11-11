using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an instance of store
    /// </summary>
    public class StoreBranch: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a name of store
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Repressent a location of store
        /// </summary>
        public string Location { get; set; } = null!;
        /// <summary>
        /// Represent some info about store
        /// </summary>
        public string Info { get; set; } = null!;
        /// <summary>
        /// Represent a date when store was opened
        /// </summary>
        public DateTime OpeningDate { get; set; }
        /// <summary>
        /// Represent employees of store
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
        /// <summary>
        /// Represent products in store
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

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
