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

        public bool InsertUser(string loginName, string password, string FirstName, string Lastname, string position, string numberemployee, string config) 
        {
            return userDao.InsertUser(loginName, password, FirstName, Lastname, position, numberemployee, config);
        }

        public bool UpdateAccess(int userId, string config)
        {
            return userDao.UpdateAccess(userId, config);
        }

        public bool QueryUser(string FirstName, string LastName) { 
            return userDao.QueryUser(FirstName, LastName);
        }
    }
}
