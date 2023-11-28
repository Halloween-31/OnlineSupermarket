using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an instance of sale
    /// </summary>
    public class Sale: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a date when sale was done
        /// </summary>
        public DateTime SaleDate { get; set; }
        /// <summary>
        /// Represent a price of all products
        /// </summary>
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmout = decimal.Zero;
                foreach (var product in this.Products)
                {
                    totalAmout += product.Price;
                }
                return totalAmout;
            }
            //Because of EF Core
            set { }
        }
        /// <summary>
        /// Represent payment methods
        /// </summary>
        /// <example>Card, Cash</example>
        public string PaymentMethod { get; set; } = null!;
        /// <summary>
        /// Represent an employee, who did sale
        /// </summary>
        public int? EmployeeId { get; set; }
        /// <summary>
        /// Represent customer, who buy products
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// The actual employee
        /// </summary>
        public virtual Employee? Employee { get; set; }
        /// <summary>
        /// The actual customer
        /// </summary>
        public virtual Customer Customer { get; set; } = null!;
        /// <summary>
        /// Represent products, which customer buy
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Sale left, Sale right)
        {
            if(left.Id != right.Id) return false;
            if(left.SaleDate != right.SaleDate) return false;
            if(left.TotalAmount != right.TotalAmount) return false;
            if(left.PaymentMethod != right.PaymentMethod) return false;
            if(left.EmployeeId != right.EmployeeId) return false;
            if(left.CustomerId != right.CustomerId) return false;
            //Employee
            //Customer
            //Products
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        /// <inheritdoc/>
        public static bool operator!=(Sale left, Sale right)
        {
            if (left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Sale;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.SaleDate != another.SaleDate) return false;
            if (this.TotalAmount != another.TotalAmount) return false;
            if (this.PaymentMethod != another.PaymentMethod) return false;
            if (this.EmployeeId != another.EmployeeId) return false;
            if (this.CustomerId != another.CustomerId) return false;
            //Employee
            //Customer
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
