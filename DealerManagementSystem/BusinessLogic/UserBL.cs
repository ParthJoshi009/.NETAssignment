using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserBL
    {
        public UserCustomBO AddUser(UserBusinessObject objUserBusinessObject)
        {
            return new UserDAL().AddUser(objUserBusinessObject);
        }

        public void AddUser(UserCustomBO objUserCustomBO)
        {
            throw new NotImplementedException();
        }
    }
}
