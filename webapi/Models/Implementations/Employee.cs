using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an instance of employee
    /// </summary>
    public class Employee: IModel
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <summary>
        /// Represent first name of employee
        /// </summary>
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Represent last name of employee
        /// </summary>
        public string LastName { get; set; } = null!;
        /// <summary>
        /// Represent a birthdate of employee
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Represent phone number of employee
        /// </summary>
        public string Phone { get; set; } = null!;
        /// <summary>
        /// Represent a position of employee
        /// </summary>
        public string Position { get; set; } = null!;
        /// <summary>
        /// Represent salary of employee
        /// </summary>
        public double Salary { get; set; }
        /// <summary>
        /// Represent store where employee works
        /// </summary>
        public int? StoreId { get; set; }
        /// <summary>
        /// Represent sales, which were done by employee
        /// </summary>
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
        /// <summary>
        /// Represent spendings, which were done by employee
        /// </summary>
        public virtual ICollection<Spending> Spendings { get; set; } = new List<Spending>();
        /// <summary>
        /// The actual store, where employee works
        /// </summary>
        public virtual StoreBranch? Store { get; set; }

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
