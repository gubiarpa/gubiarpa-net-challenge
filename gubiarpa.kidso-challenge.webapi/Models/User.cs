using Microsoft.AspNetCore.Identity;

namespace gubiarpa.kidso_challenge.webapi.Models
{
    public class User : IdentityUser
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
