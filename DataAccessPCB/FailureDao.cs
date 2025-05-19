using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using Common.Cache;
using MySqlConnector;

namespace DataAccessPCB
{
    public class FailureDao
    {
        public bool InsertFalla (string failure, string config, string failureEnglish)
        {
            string dBMsg = string.Empty;
            int dbError = 0;


            DBConnection dB = new DBConnection();
            DataTable dtResult = new DataTable();

            dB.dataBase = "datasource=MLXGUMVWPAPP02;port=3306;username=diaguser;password=diaguser123;database=diagn_pcb;";
            dB.query = "Insert into diagn_pcb.diagnfailure(failure, config, failureEnglish ) "
                                        + "VALUES ('" + failure + "', '" + config + "', '" + failureEnglish + "');";

            var dbResult = dB.InsertData(out dBMsg, out dbError);

            

            if (dbError != 0)
            {
                return false;
            }
            else
            {
                string log = Directory.GetCurrentDirectory() + @"\Log.txt";

                File.AppendAllText(log, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Falla registrada correctamente\n");

                return true;
            }
        }
    }
}
