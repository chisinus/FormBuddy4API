using FBSharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBDAL.DAL
{
    public interface ICodeTableRespository
    {
        Task<CodeTable[]> GetGenders();
        Task<CodeTable[]> GetSecurityQuestions();
    }
}
