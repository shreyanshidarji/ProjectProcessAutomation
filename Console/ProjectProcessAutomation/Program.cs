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
        }
    }
}
