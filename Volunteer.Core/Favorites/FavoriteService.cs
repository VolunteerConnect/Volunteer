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

        public Favorite AddFavorite(Favorite favorite)
        {
            try
            {
                Favorite newFavorite = _favoriteRepository.AddFavorite(favorite);
                return newFavorite;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Favorite addition failed: {e.Message}");
            }
        }

        public Favorite RemoveFavorite(int Id)
        {
            try
            {
                Favorite favorite = _favoriteRepository.GetFavorite(Id);
                favorite = _favoriteRepository.RemoveFavorite(favorite);
                return favorite;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Favorite removal failed: {e.Message}");
            }
        }

    }
}
