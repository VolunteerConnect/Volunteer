namespace VolunteerUnitTests.Favorites
{
    public class FavoriteUnitTest
    {
        [Fact]
        public void GetFavorites_ShouldReturnFavorites()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act
            IEnumerable<Favorite> favorites = service.GetFavorites("1");

            // Assert
            Assert.Equal(2, favorites.Count());

            Assert.Equal(1, favorites.First().UserId);
            Assert.Equal(1, favorites.First().OrganizationId);
            
            Assert.Equal(1, favorites.First().UserId);
            Assert.Equal(2, favorites.Last().OrganizationId);
        }
    }
}