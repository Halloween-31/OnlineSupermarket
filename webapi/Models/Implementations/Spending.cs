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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Spending left, Spending right)
        {
            if(left.Id != right.Id) return false;
            if(left.SpendingDate != right.SpendingDate) return false;
            if(left.Amount != right.Amount) return false;
            if(left.Price != right.Price) return false;
            if(left.Description != right.Description) return false;
            if(left.EmployeeId != right.EmployeeId) return false;
            if(left.SupplierId != right.SupplierId) return false;
            //Employee
            //Products
            //Supplier            
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(Spending left, Spending right)
        {
            if(left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Spending;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.SpendingDate != another.SpendingDate) return false;
            if (this.Amount != another.Amount) return false;
            if (this.Price != another.Price) return false;
            if (this.Description != another.Description) return false;
            if (this.EmployeeId != another.EmployeeId) return false;
            if (this.SupplierId != another.SupplierId) return false;
            //Employee
            //Products
            //Supplier            
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
