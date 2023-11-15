using Volunteer.Core.Organizations;

namespace Volunteer.Data.Organizations
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly VolunteerDBContext _context;

        public OrganizationRepository(string connectionString)
        {
            _context = new VolunteerDBContext(connectionString);
        }
        
        public IEnumerable<Organization> GetOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public Organization GetOrganization(int id)
        {
            return _context.Organizations.Find(id);
        }
    }
}
