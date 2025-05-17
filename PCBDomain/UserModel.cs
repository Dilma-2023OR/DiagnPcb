using System;
using DataAccessPCB;

namespace PCBDomain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }
}
