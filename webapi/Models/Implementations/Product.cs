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
                    throw new InvalidOperationException();
                }
                count = value;
            } 
        }
        private long count;
        /// <summary>
        /// Represent price of product
        /// </summary>
        public decimal Price { get; set; }
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
