using Microsoft.AspNetCore.Authorization;

namespace MultipleAuth01.Authorization
{
    public class OnlyManagersRequirement : IAuthorizationRequirement
    {
    }
}
