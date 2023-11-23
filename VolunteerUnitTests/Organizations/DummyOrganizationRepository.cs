using Volunteer.Core.Organizations;

namespace VolunteerUnitTests.Organizations
{
    public class DummyOrganizationRepository : IOrganizationRepository
    {

        private readonly List<Organization> _organizations = new List<Organization>
        {
            new Organization
            {
                Id = 1,
                Name = "ABC Inc.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                DescriptionLong = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Email = "contact@abcinc.com",
                Website = "https://www.abcinc.com",
                BannerImage = "https://www.abcinc.com/banner.jpg"
            },
            new Organization
            {
                Id = 2,
                Name = "XYZ Corporation",
                Description = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                DescriptionLong = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                Email = "info@xyzcorp.com",
                Website = "https://www.xyzcorp.com",
                BannerImage = "https://www.xyzcorp.com/banner.jpg"
            },
        };

        public IEnumerable<Organization> GetOrganizations()
        {
            return _organizations;
        }

        public Organization GetOrganization(int Id)
        {
            var organizations = _organizations.FirstOrDefault(o => o.Id == Id);
            if (organizations == null)
            {
                throw new Exception("Organization not found");
            }
            return organizations;
        }
    }
}
