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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(StoreBranch left, StoreBranch right)
        {
            if(left.Id != right.Id) return false;
            if(left.Name != right.Name) return false;
            if(left.Location != right.Location) return false;
            if(left.Info != right.Info) return false;
            if(left.OpeningDate != right.OpeningDate) return false;
            //Employees
            //Products
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(StoreBranch left, StoreBranch right)
        {
            if(left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as StoreBranch;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.Name != another.Name) return false;
            if (this.Location != another.Location) return false;
            if (this.Info != another.Info) return false;
            if (this.OpeningDate != another.OpeningDate) return false;
            //Employees
            //Products
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
            return res;
        }
    }
}
