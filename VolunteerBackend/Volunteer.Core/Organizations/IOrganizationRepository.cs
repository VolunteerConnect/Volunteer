namespace Volunteer.Core.Organizations
{
    public interface IOrganizationRepository
    {
        IEnumerable<Organization> GetOrganizations();
        Organization GetOrganization(int Id);
    }
}
