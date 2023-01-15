using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManagement.Entities
{
    [PrimaryKey(nameof(ProjectId), nameof(MemberId))]
    internal class ProjectMembers
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }
    }
}
