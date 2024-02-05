using System.Security.Claims;
using System.Security.Principal;

namespace Obosi.ng.Presentation.utility
{
    public static class IdentityExtensions
    {
        public static int GetId(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.Sid);

            if (claim == null)
                return 0;

            return int.Parse(claim.Value);
        }

        public static string GetName(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.Name);

            return claim?.Value ?? string.Empty;
        }
        public static int  GetRole(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.GroupSid);

            return int.Parse(claim.Value);
        }
    }
}
