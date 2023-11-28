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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is thet are the same</returns>
        public static bool operator==(Discount left, Discount right)
        {
            if(left.Id != right.Id) return false;
            if(left.Name != right.Name) return false;
            if(left.Description  != right.Description) return false;
            if(left.StartDate != right.StartDate) return false;
            if(left.EndDate != right.EndDate) return false;
            if(left.ProductId != right.ProductId) return false;
            //Products is not checked
            //Customer is not checked
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(Discount left, Discount right)
        {
            if(left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Discount;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.Name != another.Name) return false;
            if (this.Description != another.Description) return false;
            if (this.StartDate != another.StartDate) return false;
            if (this.EndDate != another.EndDate) return false;
            if (this.ProductId != another.ProductId) return false;
            //Products is not checked
            //Customer is not checked
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
