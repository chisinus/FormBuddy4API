using FBSharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSharedLibrary.Services
{
    public interface IServiceBase
    {
        public Task<string> CallService(string baseUrl, string api, string parameters);
    }
}
