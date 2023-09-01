using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class ProjectTable : Baseclass<int>
    {
    public string projectName { get; set; }
    public int projectTechnologyId { get; set; }
    public bool projectActive { get; set; }
    public string projectDescription { get; set; }
    public DateTime createdOn { get; set; }
    public DateTime updatedOn { get; set; }
    }
}
