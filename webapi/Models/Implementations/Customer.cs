using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an insance of customer
    /// </summary>    
    public class Customer: IModel
    { 
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent the first name of customer
        /// </summary>
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Represent the last name of customer
        /// </summary>
        public string LastName { get; set; } = null!;
        /// <summary>
        /// Represent a phone number of customer
        /// </summary>
        public string ContactInfo { get; set; } = null!;
        /// <summary>
        /// Represent an address of customer 
        /// </summary>
        public string Address { get; set; } = null!;
        /// <summary>
        /// Represent a count of loyalty points
        /// </summary>
        public int? LoyaltyPoints { get; set; }
        /// <summary>
        /// Repressent destination of delievery, if cutomer 
        /// orders on another address, that his
        /// </summary>
        public string? DestinationOfDelievery { get; set; }
        /// <summary>
        /// Represent a sale (cart) of customer
        /// </summary>
        public virtual Sale? Sale { get; set; }
        /// <summary>
        /// Represent discount which customer have
        /// </summary>
        public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
                      
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
