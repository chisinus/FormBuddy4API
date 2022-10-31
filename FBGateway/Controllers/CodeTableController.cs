using FBGateway.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FBGateway.Controllers
{
    [ApiController]
    [Route("api/codetable")]
    public class CodeTableController : ControllerBase
    {
        private ICodeTableService codeTableService;

        public CodeTableController(ICodeTableService codeTableService)
        {
            this.codeTableService = codeTableService;
        }

        [HttpGet]
        [Route("genders")]
        public async Task<IActionResult> GetGenders()
        {
            return Ok(await codeTableService.GetGenders());
        }

        [HttpGet]
        [Route("securityquestions")]
        public async Task<IActionResult> GetSecurityQuestions()
        {
            return Ok(await codeTableService.GetSecurityQuestions());
        }
    }
}
