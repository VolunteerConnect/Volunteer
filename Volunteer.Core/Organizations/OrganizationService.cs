namespace Volunteer.Core.Organizations
{
    public class OrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IOrganizationRepository repository)
        {
            _organizationRepository = repository;
        }

        public IEnumerable<Organization> GetOrganizations()
        {
            try
            {
                IEnumerable<Organization> organizations = _organizationRepository.GetOrganizations();
                return organizations;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Organization retrieval failed: {e.Message}");
            }            
        }

        public Organization GetOrganization(int id)
        {
            try
            {
                Organization organization = _organizationRepository.GetOrganization(id);
                return organization;
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Organization retrieval failed: {e.Message}");
            }
        }
    }
}
