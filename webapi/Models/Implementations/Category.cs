using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an insance of category
    /// </summary>
    public class Category : IModel
    {
        /// <inheritdoc/>        
        public int Id { get; set; }
        /// <summary>
        /// Represent the name of category
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Represent the desription of category
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Represent products which belong to this catrgory
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
                    res += propertyInfo.GetValue(this, null)?.ToString() + "\n\t";
                }
            }
            res += "\n\n\n";
            return res;
        }
    }
}
