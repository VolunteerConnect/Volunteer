using Microsoft.AspNetCore.Mvc;

namespace volunteer.Controllers
{
    [ApiController]
    [Route("api")]
    public class OrganizationController : ControllerBase
    {
        private readonly List<Organization> organizations = new List<Organization> {
            new Organization(1, "International Committee of the Red Cross", "The International Committee of the Red Cross (ICRC) ensuring humanitarian protection and assistance for victims of war and other situations of violence.", "https://www.icrc.org/", "https://www.icrc.org/sites/default/themes/icrc_theme/images/en/logo.png"),
            new Organization(2, "Doctors Without Borders", "Doctors Without Borders (MSF) treats people where the need is greatest. We are an international medical humanitarian organisation. We help people threatened by violence, neglect, natural disasters, epidemics and health emergencies", "https://www.doctorswithoutborders.org/", "https://www.doctorswithoutborders.org/themes/custom/msf/logo.svg"),
        };

        [HttpGet("organizations", Name = "GetAllOrganizations")]
        public IEnumerable<Organization> Get()
        {
            return organizations;
        }
    }
}
