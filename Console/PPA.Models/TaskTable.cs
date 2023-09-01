using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class TaskTable : Baseclass<int>
    {
        public string taskName { get; set; } 

        public int taskType { get; set; }
        public int projectId { get; set; }
        public int activityId { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }

    }
   

}
