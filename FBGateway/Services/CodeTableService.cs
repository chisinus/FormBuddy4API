using FBDAL.DAL;
using FBSharedLibrary.Models;

namespace FBGateway.Services
{
    public class CodeTableService : ICodeTableService
    {
        private ICodeTableRespository codeTableRespository;

        public CodeTableService(ICodeTableRespository codeTableRespository)
        {
            this.codeTableRespository = codeTableRespository;
        }

        public async Task<CodeTable[]> GetGenders()
        {
            return await codeTableRespository.GetGenders();
        }

        public async Task<CodeTable[]> GetSecurityQuestions()
        {
            return await codeTableRespository.GetSecurityQuestions();
        }
    }
}
