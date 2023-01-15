using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManagement.Entities
{
    [PrimaryKey(nameof(MemberId), nameof(CompetenceId))]
    internal class MemberCompetencies
    {
        public int MemberId { get; set; }
        
        public Member Member { get; set; }
        
        public int CompetenceId { get; set; }

        public ProjectType Competence { get; set; }
    }
}
