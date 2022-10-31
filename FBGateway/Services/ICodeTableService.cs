using FBSharedLibrary.Models;

namespace FBGateway.Services
{
    public interface ICodeTableService
    {
        Task<CodeTable[]> GetGenders();
        Task<CodeTable[]> GetSecurityQuestions();
    }
}
