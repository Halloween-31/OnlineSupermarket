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



        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Employee left, Employee right)
        {
            if(left.Id != right.Id) return false;
            if(left.FirstName != right.FirstName) return false;
            if(left.LastName != right.LastName) return false;
            if(left.DateOfBirth != right.DateOfBirth) return false;
            if(left.Phone != right.Phone) return false;
            if(left.Position != right.Position) return false;
            if(left.Salary != right.Salary) return false;
            if(left.StoreId != right.StoreId) return false;
            //Sales is not checked
            //Spendings is not checked
            //Store is not checked
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator !=(Employee left, Employee right)
        {
            if(left == right) return false;
            return true;
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Employee;
            if (another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.FirstName != another.FirstName) return false;
            if (this.LastName != another.LastName) return false;
            if (this.DateOfBirth != another.DateOfBirth) return false;
            if (this.Phone != another.Phone) return false;
            if (this.Position != another.Position) return false;
            if (this.Salary != another.Salary) return false;
            if (this.StoreId != another.StoreId) return false;
            //Sales is not checked
            //Spendings is not checked
            //Store is not checked
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
