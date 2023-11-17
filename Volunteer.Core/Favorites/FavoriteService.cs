namespace Volunteer.Core.Favorites
{
    public class FavoriteService
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteService(IFavoriteRepository repository)
        {
            _favoriteRepository = repository;
        }

        public IEnumerable<Favorite> GetFavorites(string UserId)
        {
            try
            {
                IEnumerable<Favorite> favorites = _favoriteRepository.GetFavorites(UserId);
                return favorites;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Favorite retrieval failed: {e.Message}");
            }            
        }

        public Favorite SetFavorite(string UserId, int OrganizationId)
        {
            try
            {
                Favorite favorite = new Favorite
                {
                    UserId = UserId,
                    FavoriteOrganizationId = OrganizationId
                };
                favorite = _favoriteRepository.SetFavorite(favorite);
                return favorite;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Favorite creation failed: {e.Message}");
            }
        }

        public Favorite RemoveFavorite(int Id)
        {
            try
            {
                Favorite favorite = _favoriteRepository.RemoveFavorite(Id);
                return favorite;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Favorite removal failed: {e.Message}");
            }
        }

    }
}
