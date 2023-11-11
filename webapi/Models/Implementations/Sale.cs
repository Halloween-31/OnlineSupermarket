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
