using PPA.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProcessAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCrud usercrud = new UserCrud();
            usercrud.insertUser();

            //TaskTableCrud taskTableCrud = new TaskTableCrud();
            //taskTableCrud.insertTask();

            //RoleTableCrud roleTableCrud = new RoleTableCrud();
            //roleTableCrud.insertRole();

            // ProjectTechnologyTableCrud projectTechnologyTableCrud = new ProjectTechnologyTableCrud();
            //projectTechnologyTableCrud.insertProjectTechnology();

            // ProjectTableCrud projectTableCrud = new ProjectTableCrud();
            //projectTableCrud.insertProject();

            //LookUpValueTableCrud lookUpValueTableCrud = new LookUpValueTableCrud();
            // lookUpValueTableCrud.insertLookUpValue();

            // CompletedTaskTableCrud completedTaskTableCrud = new PPA.DataAccess.CompletedTaskTableCrud();
            // completedTaskTableCrud.insertCompletedTask();
            //completedTaskTableCrud.deleteCompletedTask();

            //AttachmentTableCrud attachmentTableCrud = new AttachmentTableCrud();
            //attachmentTableCrud.insertAttachment();

            //AssignTaskToUserTableCrud assignTaskToUserTableCrud = new AssignTaskToUserTableCrud();
            //assignTaskToUserTableCrud.insertAssignTaskToUser();

            //AssignRoleTableCrud assignRoleTableCrud = new AssignRoleTableCrud();
            //assignRoleTableCrud.insertAssignRole();

            //AssignProjectToUserTableCrud assignProjectToUserTableCrud = new AssignProjectToUserTableCrud();
            //assignProjectToUserTableCrud.insertAssignProjectToUser();

            // ActivityTableCrud activityTableCrud = new ActivityTableCrud();
            // activityTableCrud.insertActivity();
        }
    }
}
