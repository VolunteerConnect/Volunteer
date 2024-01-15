using Volunteer.Core.Favorites;
using Volunteer.Core.Organizations;

namespace VolunteerUnitTests.Favorites
{
    public class DummyFavoriteRepository : IFavoriteRepository
    {
        private readonly List<Favorite> _favorites = new List<Favorite>{
            new Favorite
            {
                Id = 1,
                UserId = "1",
                FavoriteOrganizationId = 1
            },
            new Favorite
            {
                Id = 2,
                UserId = "1",
                FavoriteOrganizationId = 2
            },
            new Favorite
            {
                Id = 3,
                UserId = "2",
                FavoriteOrganizationId = 1
            }
        };

        public Favorite GetFavorite(int Id)
        {
            var favorite = _favorites.FirstOrDefault(favorite => favorite.Id == Id);
            if (favorite == null)
            {
                throw new Exception("Favorite not found");
            }
            return favorite;
        }

        public IEnumerable<Favorite> GetFavorites(string UserId)
        {
            var favorites = _favorites.Where(favorite => favorite.UserId == UserId);
            if (favorites.Count() == 0)
            {
                throw new Exception("Favorites not found");
            }
            return favorites;
        }

        public Favorite AddFavorite(Favorite favorite)
        {
            var existingFavorite = _favorites.FirstOrDefault(f => f.UserId == favorite.UserId && f.FavoriteOrganizationId == favorite.FavoriteOrganizationId);

            if (existingFavorite != null)
            {
                throw new Exception("Favorite already exists");
            }

            _favorites.Add(favorite);
            return favorite;
        }

        public Favorite RemoveFavorite(Favorite favorite)
        {
            if (favorite == null)
            {
                throw new Exception("Favorite not found");
            }
            _favorites.Remove(favorite);
            return favorite;
        }

        public IEnumerable<Organization> GetFavoriteOrganizations(string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
