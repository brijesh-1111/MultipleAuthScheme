using Microsoft.AspNetCore.Authorization;

namespace MultipleAuth01.Authorization
{
    public class OnlyEmployeesRequirement : IAuthorizationRequirement
    {
    }
}
