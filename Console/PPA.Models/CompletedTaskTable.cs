using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class CompletedTaskTable : Baseclass<int>
    {
        public int taskId { get; set; }
        public int userId { get; set; }
        public int attachmentId { get; set; }
        public string comment { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
    }
}
