using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class AssignProjectToUserTable:Baseclass<int>
    {
        public int projectId { get; set; }
        public int userId { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }

    }
}
