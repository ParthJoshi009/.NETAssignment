using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class UserDAL
    {
        private UserDbEntities5 objUserDbEntities5;
        public UserDAL()
        {
            objUserDbEntities5 = new UserDbEntities5();

        }
        public UserCustomBO AddUser(UserBusinessObject objUserBusinessObject)
        {
            UserCustomBO objUserCustomBO = new UserCustomBO();
            User objUser = new User()
            {
                UserAddress = objUserBusinessObject.UserAddress,
                UserEmail = objUserBusinessObject.UserEmail,
                UserMobile = objUserBusinessObject.UserPhone,
                UserName = objUserBusinessObject.UserName
            };
            objUserDbEntities5.Users.Add(objUser);
            int returnValue = objUserDbEntities5.SaveChanges();

            if (returnValue > 0)
            {
                objUserCustomBO.CustomMessage = "Data Successfully Added";
                objUserCustomBO.CustomMessageNumber = returnValue;
            }

            else
            {
                objUserCustomBO.CustomMessage = "There is some problem to add User.";
                objUserCustomBO.CustomMessageNumber = returnValue;
            }

            return objUserCustomBO;
        }
    }
}
