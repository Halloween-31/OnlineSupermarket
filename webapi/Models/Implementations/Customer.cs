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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Customer left, Customer right)
        {
            if(left.Id != right.Id) return false;
            if(left.FirstName != right.FirstName) return false;
            if(left.LastName != right.LastName) return false;
            if(left.ContactInfo != right.ContactInfo) return false;
            if(left.Address != right.Address) return false;
            if(left.LoyaltyPoints != right.LoyaltyPoints) return false;
            //DestinationOfDelievery is not checked

            //potentially doesnt included
            //if(left.Sale != right.Sale) return false;

            //Discounts is not checked
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(Customer left, Customer right)
        {
            if (left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Customer;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.FirstName != another.FirstName) return false;
            if (this.LastName != another.LastName) return false;
            if (this.ContactInfo != another.ContactInfo) return false;
            if (this.Address != another.Address) return false;
            if (this.LoyaltyPoints != another.LoyaltyPoints) return false;
            //DestinationOfDelievery is not checked

            //potentially not included
            //if (this.Sale != another.Sale) return false;

            //Discounts is not checked
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
                    res += propertyInfo.GetValue(this, null)?.ToString() + "\n\t";
                }
            }            
            return res;
        }
    }
}
