using System;
using System.Data;
using System.IO;
using Common.Cache;
using MySqlConnector;

namespace DataAccessPCB
{
    public class UserDao
    {
        string connect = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
        DBConnection dB = new DBConnection();
        System.Data.DataTable dtResult = new System.Data.DataTable();

        public bool Login(string user, string pass)
        {
            using (var connection = new MySqlConnection(connect))
            {
                connection.Open();

                
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from diagn_pcb.users where (LoginName = @user and Password = @pass); ";
                    // Pasar los parámetros desde el objeto Cliente
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.UserID = Convert.ToInt32(reader["UserID"].ToString());
                            UserCache.LoginName = reader["LoginName"].ToString();
                            UserCache.Password = reader["Password"].ToString();
                            UserCache.FirstName = reader["FirstName"].ToString();
                            UserCache.LastName = reader["LastName"].ToString();
                            UserCache.Position = reader["Position"].ToString();
                            UserCache.NumberEmployee = reader["NumberEmployee"].ToString();
                            UserCache.config = reader["config"].ToString();
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool InsertUser(string loginName, string Password, string FirstName, string Lastname, string position, string numberemployee, string config)
        {
            string dBMsg = string.Empty;
            int dbError = 0;


            DBConnection dB = new DBConnection();
            DataTable dtResult = new DataTable();

            dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
            dB.query = "Insert into diagn_pcb.Users(LoginName, Password, FirstName, LastName, Position, NumberEmployee, config ) "
                                        + "VALUES ('" + loginName + "', '" + Password + "', '" + FirstName + "', '" + Lastname + "', '" + position + "', '" + 
                                        numberemployee + "', '" + config + "');";

            var dbResult = dB.InsertData(out dBMsg, out dbError);



            if (dbError != 0)
            {
                return false;
            }
            else
            {
                string log = Directory.GetCurrentDirectory() + @"\Log.txt";

                File.AppendAllText(log, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",User registered correctly\n");

                return true;
            }
        }

    }
}
    