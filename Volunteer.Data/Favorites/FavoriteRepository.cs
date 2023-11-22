using Volunteer.Core.Favorites;

namespace Volunteer.Data.Favorites
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly VolunteerDBContext _context;

        public FavoriteRepository(string connectionString)
        {
            _context = new VolunteerDBContext(connectionString);
        }

        public Favorite GetFavorite(int Id)
        {
            var favorite = _context.Favorites.Find(Id);
            if (favorite == null)
            {
                throw new Exception("Favorite not found");
            }
            return favorite;
        }

        public IEnumerable<Favorite> GetFavorites(string UserId)
        {
            List<Favorite> favorites = _context.Favorites.Where(f => f.UserId == UserId).ToList();
            if (favorites.Count == 0)
            {
                throw new Exception("Favorites not found");
            }
            return favorites;
        }

        public Favorite AddFavorite(Favorite favorite)
        {
            _context.Favorites.Add(favorite);
            _context.SaveChanges();
            return favorite;
        }  
        
        public Favorite RemoveFavorite(Favorite favorite)
        {
            if (favorite == null)
            {
                throw new ArgumentNullException(nameof(favorite));
            }

            _context.Favorites.Remove(favorite);
            _context.SaveChanges();
            return favorite;
        }
    }
}
