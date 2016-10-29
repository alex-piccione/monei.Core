using monei.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei.Core.Interfaces
{
    public interface ICategoryManager
    {
        /// <summary>
        /// Save a Category in the storage and return the saved entity.
        /// </summary>
        Category Create(Category category);

        /// <exception cref="ItemHasChildrenException">When Category has Subcategories.</exception>
        Category Delete(int categoryId);
    }
}
