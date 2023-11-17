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

        public IEnumerable<Favorite> GetFavorites(string UserId)
        {
            return _context.Favorites.Where(f => f.UserId == UserId).ToList();
        }

        public Favorite SetFavorite(Favorite favorite)
        {
            _context.Favorites.Add(favorite);
            _context.SaveChanges();
            return favorite;
        }  
        
        public Favorite RemoveFavorite(int Id)
        {
            Favorite favoriteToRemove = _context.Favorites.Find(Id);
            _context.Favorites.Remove(favoriteToRemove);
            _context.SaveChanges();
            return favoriteToRemove;
        }
    }
}
