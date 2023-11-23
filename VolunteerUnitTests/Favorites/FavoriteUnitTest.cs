using Volunteer.Core.Favorites;

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

            Assert.Equal("1", favorites.First().UserId);
            Assert.Equal(1, favorites.First().FavoriteOrganizationId);
            
            Assert.Equal("1", favorites.First().UserId);
            Assert.Equal(2, favorites.Last().FavoriteOrganizationId);
        }

        [Fact]
        public void GetFavorites_ShouldThrowException()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.GetFavorites("3"));
        }

        [Fact]
        public void AddFavorite_ShouldReturnFavorite()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act
            Favorite favorite = service.AddFavorite(new Favorite
            {
                Id = 4,
                UserId = "2",
                FavoriteOrganizationId = 2
            });

            // Assert
            Assert.Equal(4, favorite.Id);
            Assert.Equal("2", favorite.UserId);
            Assert.Equal(2, favorite.FavoriteOrganizationId);
        }

        [Fact]
        public void AddFavorite_ShouldThrowException()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.AddFavorite(new Favorite
            {
                Id = 1,
                UserId = "1",
                FavoriteOrganizationId = 1
            }));
        }

        [Fact]
        public void RemoveFavorite_ShouldReturnFavorite()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act
            Favorite favorite = service.RemoveFavorite(3);

            // Assert
            Assert.Equal(3, favorite.Id);
            Assert.Equal("2", favorite.UserId);
            Assert.Equal(1, favorite.FavoriteOrganizationId);
        }

        [Fact]
        public void RemoveFavorite_ShouldThrowException()
        {
            // Arrange
            var repository = new DummyFavoriteRepository();
            var service = new FavoriteService(repository);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.RemoveFavorite(5));
        }
    }
}
