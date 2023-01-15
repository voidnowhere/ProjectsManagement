using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManagement.Entities
{
    [Index(nameof(MemberId), nameof(ProjectId), IsUnique = true)]
    internal class ProjectMember
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }
    }
}
