using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManagement.Entities
{
    [Index(nameof(MemberId), nameof(CompetenceId), IsUnique = true)]
    internal class MemberCompetence
    {
        public int Id { get; set; }

        public int MemberId { get; set; }
        
        public Member Member { get; set; }
        
        public int CompetenceId { get; set; }

        public ProjectType Competence { get; set; }
    }
}
