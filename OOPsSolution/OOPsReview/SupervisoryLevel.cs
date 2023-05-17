using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public enum SupervisoryLevel
    {
        /// <summary>
        /// by default enum names are strings representing an integer value
        /// by default the integer values start at zero and increment by one
        /// one could assign their own value to each of the enum names
        /// </summary>
        Entry,
        TeamMember,
        TeamLeader,
        Supervisor,
        DepartmentHead,
        Owner
    }
}
