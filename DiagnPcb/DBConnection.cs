using System;
using MySqlConnector;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnPcb
{
    internal class DBConnection
    {
        //MySqlConnector conn = null;
        MySqlConnection conn = null;
        //General Data
        public string dataBase = null;
        public string query = "";
        string msg = "";
        int error = 0;

        private void connectBD()
        {
            try
            {
                //Open conecction
                conn = new MySqlConnection(dataBase);
                conn.Open();

                error = 0;
            }
            catch (Exception ex) {
                //Response
                msg = "Error al conectar a la Base de Datos.";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al conectar a la Base de Datos:" + ex.Message + "\n");
            }
        }

        private void disconnectBD()
        {
            try
            {
                if (error == 0)
                {
                    conn.Close();

                    //Control
                    error = 0;
                }
            }
            catch (Exception ex)
            {
                //Response
                msg = "Error al desconectar a la Base de Datos.";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al desconectar a la Base de Datos:" + ex.Message + "\n");
            }
        }

        public MySqlDataAdapter getData(out string result, out int errors)
        {
            //Reader MySql
            MySqlDataAdapter reader = new MySqlDataAdapter();
            //Connect
            connectBD();

            if (error == 0)
            {
                try
                {
                    //Execute Query
                    var command = new MySqlCommand(query, conn);
                    reader.SelectCommand = command;
                    error = 0;
                }
                catch (Exception ex)
                {
                    //Response
                    msg = "Error al consultar la Base de Datos.";
                    error = 1;

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + "\\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al consultar la Base de Datos:" + ex.Message + "\n");
                }
            }

            //Disconnect
            disconnectBD();

            //Response
            result = msg;
            errors = error;

            //Reader
            return reader;
        }

        public MySqlDataReader setData(out string result, out int errors) { 
            //Reader MySQL
            MySqlDataReader reader = null;

            //Connect
            connectBD();

            if (error == 0)
            {
                try
                {
                    //Execute Query
                    var command = new MySqlCommand(query, conn);
                    reader = command.ExecuteReader();
                    error = 0;
                }
                catch (Exception ex) {
                    //Response
                    msg = "Error al consultar la Base de Datos.";
                    error = 1;

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + "\\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al consultar la Base de Datos:" + ex.Message + "\n");
                }
            }
            //Disconnect
            disconnectBD();

            //Response
            result = msg;
            errors = error;

            //Reader
            return reader;
        }

        public int InsertData(out string result, out int errors)
        {
            //Reader MySql
            MySqlDataAdapter reader = new MySqlDataAdapter();
            int rowsAffected = 0;
            //Connect
            connectBD();

            if (error == 0)
            {
                try
                {
                    //Execute Query
                    var command = new MySqlCommand(query, conn);
                    rowsAffected = command.ExecuteNonQuery();
                    error = 0;
                }
                catch (Exception ex)
                {
                    //Response
                    msg = "Error al insertar en la Base de Datos.";
                    error = 1;

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + "\\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al insertar en la Base de Datos:" + ex.Message + "\n");
                }
            }

            //Disconnect
            disconnectBD();

            //Response
            result = msg;
            errors = error;

            //Reader
            return rowsAffected;
        }
    }
}
