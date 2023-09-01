using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class AssignTaskToUserTable : Baseclass<int>
    {
        public int taskId { get; set; }
        public int userId { get; set; }
        public int attachmentId { get; set; }
        public int taskStatus { get; set; }
        //comes from lookupvalue
        public string assignTaskComment { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
    }
}
