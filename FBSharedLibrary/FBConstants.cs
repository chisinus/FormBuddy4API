using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSharedLibrary
{
    public static class FBConstants
    {
        public enum AccountStaus
        {
            Active = 1,
            PendingApproval = 2,
            Deactivated = 3
        }
    }
}
