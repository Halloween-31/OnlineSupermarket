using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an instance of product
    /// </summary>
    public class Product: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent a name of product
        /// </summary>
        public string ProductName { get; set; } = null!;
        /// <summary>
        /// Represent a descriotion of product
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Represent a count (amount) of product
        /// </summary>
        public long Count { 
            get 
            {
                return count;
            } 
            set 
            {
                if(value < 0)
                {
                    throw new InvalidDataException();
                }
                count = value;
            } 
        }        
        private long count;
        /// <summary>
        /// Represent price of product
        /// </summary>
        public decimal Price { 
            get
            {
                return price;
            }
            set
            {
                if( value < 0)
                {
                    throw new InvalidDataException();
                }
                price = value;
            }
        }
        private decimal price;
        /// <summary>
        /// Represent category, product belogns to
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Represent spending, in which product was bought
        /// </summary>
        public int? SpendingId { get; set; }
        /// <summary>
        /// Represent supplier, who supplied product
        /// </summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// The actual category
        /// </summary>
        public virtual Category Category { get; set; } = null!;
        /// <summary>
        /// Repressent discount, in which product is
        /// </summary>
        public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
        /// <summary>
        /// The actual soending
        /// </summary>
        public virtual Spending? Spending { get; set; } = null!;
        /// <summary>
        /// Represent store where product is
        /// </summary>
        public virtual ICollection<StoreBranch> StoreBranches { get; set; } = new List<StoreBranch>();
        /// <summary>
        /// The actual supplier
        /// </summary>
        public virtual Supplier? Supplier { get; set; } = null!;
        /// <summary>
        /// Represent sales, where products is
        /// </summary>
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Product left, Product right)
        {
            if(left.Id  != right.Id) return false;
            if(left.ProductName != right.ProductName) return false;
            if(left.Description != right.Description) return false;
            if(left.Count != right.Count) return false;
            if(left.Price != right.Price) return false;
            if(left.CategoryId != right.CategoryId) return false;
            if(left.SpendingId != right.SpendingId) return false;
            if(left.SupplierId != right.SupplierId) return false;
            //Discounts
            //Spending
            //StoreBranches
            //Supplier
            //Sales
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator !=(Product left, Product right)
        {
            if(left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Product;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.ProductName != another.ProductName) return false;
            if (this.Description != another.Description) return false;
            if (this.Count != another.Count) return false;
            if (this.Price != another.Price) return false;
            if (this.CategoryId != another.CategoryId) return false;
            if (this.SpendingId != another.SpendingId) return false;
            if (this.SupplierId != another.SupplierId) return false;
            //Discounts
            //Spending
            //StoreBranches
            //Supplier
            //Sales
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
