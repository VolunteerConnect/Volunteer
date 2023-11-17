namespace Volunteer.Core.Favorites
{
    public interface IFavoriteRepository
    {
        IEnumerable<Favorite> GetFavorites(string UserId);
        Favorite SetFavorite(Favorite favorite);
        Favorite RemoveFavorite(int Id);
    }
}
