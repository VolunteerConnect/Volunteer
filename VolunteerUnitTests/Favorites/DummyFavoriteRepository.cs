using Volunteer.Core.Favorites;

namespace VolunteerUnitTests.Favorites
{
    public class DummyOrganizationRepository : IFavoriteRepository
    {
        private readonly List<Favorite> _favorites = new List<Favorite>{
            new Favorite
            {
                Id = 1,
                UserId = "1",
                OrganizationId = 1
            },
            new Favorite
            {
                Id = 2,
                UserId = "1",
                OrganizationId = 2
            },
            new Favorite
            {
                Id = 3,
                UserId = "2",
                OrganizationId = 1
            }
        };

        public IEnumerable<Favorite> GetFavorites(string UserId)
        {
            return _favorites.Where(favorite => favorite.UserId == UserId);
        }
    }
}