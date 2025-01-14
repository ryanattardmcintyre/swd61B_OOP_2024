using BusinessLogicLayer.DataContext;
using CommonDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class CategoriesRepository
    {
        private LibraryContext _context;
        public CategoriesRepository(LibraryContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
