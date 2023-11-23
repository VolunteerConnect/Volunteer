namespace Volunteer.Core.Favorites
{
    public class Favorite
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int FavoriteOrganizationId { get; set; }
    }
}
