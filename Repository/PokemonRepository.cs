using ReviewApp.Data;
using ReviewApp.Interfaces;
using ReviewApp.Models;

namespace ReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context= context;
        }
        
        public ICollection<Pokemon> GetPokemons ()
        {
            return _context.Pokemons.OrderBy(p=> p.Id).ToList();
        }

        public Pokemon GetPokemon(int pokeId)
        {
            return _context.Pokemons.Where(p => p.Id == pokeId).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            //throw new NotImplementedException();
            return _context.Pokemons.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);
            if (review.Count() <= 0)
                return 0;

            return (decimal)review.Sum(r=> r.Rating)/ review.Count();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemons.Any(p=> p.Id == pokeId);
        }
        
        //bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon) 
        //bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        //bool DeletePokemon(Pokemon pokemon);
        //bool Save();
    }
}
