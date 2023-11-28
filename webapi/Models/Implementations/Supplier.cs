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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Supplier left, Supplier right)
        {
            if(left.Id != right.Id) return false;
            if(left.SupplierName != right.SupplierName) return false;
            if(left.ContactInfo != right.ContactInfo) return false;
            if(left.Address != right.Address) return false;
            //Products
            //Spendings
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(Supplier left, Supplier right)
        {
            if (left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Supplier;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.SupplierName != another.SupplierName) return false;
            if (this.ContactInfo != another.ContactInfo) return false;
            if (this.Address != another.Address) return false;
            //Products
            //Spendings
            return true;
        }
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
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
