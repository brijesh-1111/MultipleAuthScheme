using System.Threading.Tasks;

namespace MultipleAuth01.Authentication
{
    public interface IGetApiKeyQuery
    {
        Task<ApiKey> Execute(string providedApiKey);
    }
}
