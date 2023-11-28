using AutoMapper.Internal.Mappers;
using System.Reflection;
using webapi.Models.Interfaces;

namespace webapi.Models.Implementations
{
    /// <summary>
    /// Represent an insance of category
    /// </summary>
    public class Category : IModel
    {
        /// <inheritdoc/>        
        public int Id { get; set; }
        /// <summary>
        /// Represent the name of category
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Represent the desription of category
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Represent products which belong to this catrgory
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        


        /// <summary>
        /// Checks are two instance are the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are the same</returns>
        public static bool operator==(Category left, Category right)
        {
            if(left.Id != right.Id) return false;
            if(left.Name != right.Name) return false;
            if(left.Description != right.Description) return false;
            if(!left.Products.SequenceEqual(right.Products)) return false;
            return true;
        }
        /// <summary>
        /// Checks are two instance are not the same
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool, is they are not the same</returns>
        public static bool operator!=(Category left, Category right)
        {
            if(left == right) return false;
            return true;
        }        
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var another = obj as Category;
            if(another is null)
            {
                return false;
            }
            if (this.Id != another.Id) return false;
            if (this.Name != another.Name) return false;
            if (this.Description != another.Description) return false;
            if (!this.Products.SequenceEqual(another.Products)) return false;
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
