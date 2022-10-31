using System;
using System.Collections.Generic;

namespace FBDAL.Entities
{
    public partial class TblInvitation
    {
        public int InvitationId { get; set; }
        public int CompanyId { get; set; }
        public int CompanyRoleId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectRoleId { get; set; }
        public string InviteeEmails { get; set; } = null!;
        public int InvitedBy { get; set; }
        public DateTime InvitedOn { get; set; }
        public string Message { get; set; } = null!;
        public int StatusId { get; set; }

        public virtual TblCompany Company { get; set; } = null!;
        public virtual TblDictCompanyRole CompanyRole { get; set; } = null!;
        public virtual TblUser InvitedByNavigation { get; set; } = null!;
        public virtual TblProject Project { get; set; } = null!;
        public virtual TblDictProjectRole ProjectRole { get; set; } = null!;
        public virtual TblDictStatus Status { get; set; } = null!;
    }
}
