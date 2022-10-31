using FBDAL.Context;
using FBDAL.Entities;
using FBSharedLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBDAL.DAL
{
    public class CodeTableRespository: ICodeTableRespository
    {
        private FormBuddyContext context;
        public CodeTableRespository(FormBuddyContext context)
        {
            this.context = context;
        }

        public async Task<CodeTable[]> GetGenders()
        {
            return await context.TblDictGenders.Select(g => new CodeTable { Id = g.Id, Description = g.Description }).ToArrayAsync();
        }

        public async Task<CodeTable[]> GetSecurityQuestions()
        {
            return await context.TblDictSecurityQuestions.Select(s => new CodeTable { Id = s.Id, Description = s.Description }).ToArrayAsync();
        }
    }
}
