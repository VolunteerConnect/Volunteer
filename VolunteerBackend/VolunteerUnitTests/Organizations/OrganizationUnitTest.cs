using Volunteer.Core.Organizations;

namespace VolunteerUnitTests.Organizations
{
    public class OrganizationUnitTest
    {
        [Fact]
        public void GetOrganizations_ShouldReturnOrganizations()
        {
            // Arrange
            var repository = new DummyOrganizationRepository();
            var service = new OrganizationService(repository);

            // Act
            IEnumerable<Organization> organizations = service.GetOrganizations();

            // Assert
            Assert.Equal(2, organizations.Count());

            Assert.Equal("ABC Inc.", organizations.First().Name);
            Assert.Equal("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", organizations.First().Description);
            Assert.Equal("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", organizations.First().DescriptionLong);
            Assert.Equal("contact@abcinc.com", organizations.First().Email);
            Assert.Equal("https://www.abcinc.com", organizations.First().Website);
            Assert.Equal("https://www.abcinc.com/banner.jpg", organizations.First().BannerImage);

            Assert.Equal("XYZ Corporation", organizations.Last().Name);
            Assert.Equal("Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", organizations.Last().Description);
            Assert.Equal("Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", organizations.Last().DescriptionLong);
            Assert.Equal("https://www.xyzcorp.com", organizations.Last().Website);
            Assert.Equal("https://www.xyzcorp.com/banner.jpg", organizations.Last().BannerImage);
        }

        [Fact]
        public void GetOrganization_ShouldReturnOrganization()
        {
            // Arrange
            var repository = new DummyOrganizationRepository();
            var service = new OrganizationService(repository);

            // Act
            Organization organization = service.GetOrganization(1);

            // Assert
            Assert.Equal("ABC Inc.", organization.Name);
            Assert.Equal("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", organization.Description);
            Assert.Equal("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", organization.DescriptionLong);
            Assert.Equal("https://www.abcinc.com", organization.Website);
            Assert.Equal("https://www.abcinc.com/banner.jpg", organization.BannerImage);
        }
        
        [Fact]
        public void GetOrganization_ShouldThrowException()
        {
            // Arrange
            var repository = new DummyOrganizationRepository();
            var service = new OrganizationService(repository);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.GetOrganization(3));
        }
    }
}
