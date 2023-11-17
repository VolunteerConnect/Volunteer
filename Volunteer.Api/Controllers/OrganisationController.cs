using Microsoft.AspNetCore.Mvc;
using Volunteer.Core.Organizations;
using Volunteer.Data.Organizations;

namespace volunteer.Controllers
{
    [ApiController]
    [Route("api")]
    public class OrganizationController : ControllerBase
    {
        private readonly OrganizationService _organizationService;
        private readonly string _connectionString;

        public OrganizationController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _organizationService = new OrganizationService(new OrganizationRepository(_connectionString));
        }

        [HttpGet("organizations", Name = "GetAllOrganizations")]
        public IActionResult GetOrganizations()
        {
            try
            {
                IEnumerable<Organization> organizations = _organizationService.GetOrganizations();
                return Ok(organizations);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet("organization/{id}", Name = "GetOrganizationById")]
        public IActionResult GetOrganization(int id)
        {
            try
            {
                Organization organization = _organizationService.GetOrganization(id);
                return Ok(organization);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}
