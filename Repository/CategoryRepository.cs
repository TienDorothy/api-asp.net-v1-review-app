using ReviewApp.Data;
using ReviewApp.Interfaces;
using ReviewApp.Models;

namespace ReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context= context;
        }
       public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

       public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault(); 
        }

       public  ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(pc=> pc.CategoryId == categoryId).Select(pc=> pc.Pokemon).ToList();
        }

    }
}
