using Volunteer.Core.Favorites;
using Volunteer.Core.Organizations;

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
            var favorites = _context.Favorites.Where(f => f.UserId == UserId).ToList();
            if (favorites.Count == 0)
            {
                throw new Exception("Favorites not found");
            }
            return favorites;
        }
        public IEnumerable<Organization> GetFavoriteOrganizations(string UserId)
        {
            List<Favorite> favorites = _context.Favorites.Where(f => f.UserId == UserId).ToList();
            List<Organization> favoriteOrganizations = new List<Organization>();

            foreach (Favorite favorite in favorites)
            {
                Organization favoriteOrganisation = _context.Organizations.Where(organization => organization.Id == favorite.FavoriteOrganizationId).Single();
                favoriteOrganizations.Add(favoriteOrganisation);
            }

            return favoriteOrganizations;
        }

        public Favorite AddFavorite(Favorite favorite)
        {
            var existingFavorite = _context.Favorites.FirstOrDefault(f => f.UserId == favorite.UserId && f.FavoriteOrganizationId == favorite.FavoriteOrganizationId);

            if (existingFavorite != null)
            {
                throw new Exception("Favorite already exists");
            }

            _context.Favorites.Add(favorite);
            _context.SaveChanges();
            return favorite;
        }

        public Favorite RemoveFavorite(Favorite favorite)
        {
            if (favorite == null)
            {
                throw new Exception("Favorite not found");
            }

            _context.Favorites.Remove(favorite);
            _context.SaveChanges();
            return favorite;
        }
    }
}
