using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication2
{
    public class DataAccess
    {
        private string connectionString; // used to store the connection string
        private SqlConnection objConnection; // Database connection object
        public SqlCommand objSqlCommand=new SqlCommand();
        private string procName;
        public DataTable objDataTable=new DataTable();
      
        public SqlConnection Connection
        {
            get { return this.objConnection; }
        }

        public DataAccess()
        {
            connectionString = ("server=DESKTOP-2BK9AJU\\VVS_SQL;Trusted_Connection=yes;database=VVS Prefab; connection timeout=30");         
        }
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        public string ProcName
        {
            get
            {
                return procName;
            }
            set
            {
                procName = value;
            }
        }
        /// <summary>
        /// Usage = Return a connection to SqlServer
        /// Note = This method to be removed after all the classes are updated.
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            return objConnection;
        }

        /// <summary>
        /// Usage = Opens a new connection with database
        /// </summary>
        public void OpenDBConnection()
        {
            objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
        }

        /// <summary>
        /// Usage = Sets the parameters and value of stored procedure
        /// 
        /// </summary>
        public void Parameters(string name, SqlDbType type, int size, int val)
        {
            objSqlCommand.Parameters[name].Value = val;
        }

        public void Parameters(string name, SqlDbType type, DateTime val)
        {
            objSqlCommand.Parameters.Add(name, type).Value = val;
        }
        public void Parameters(string name, SqlDbType type, double val)
        {
            objSqlCommand.Parameters.Add(name, type).Value = val;
        }
        public void Parameters(string name, decimal val)
        {
            objSqlCommand.Parameters.AddWithValue(name, val);
        }
        public void Parameters(string name, SqlDbType type, string val)
        {
            objSqlCommand.Parameters.Add(name, type).Value = val;

        }
        public void Parameters(string name, SqlDbType type, bool val)
        {
            objSqlCommand.Parameters.Add(name, type).Value = val;
        }
        
        public void Parameters(string name, string val)
       {
            objSqlCommand.Parameters.AddWithValue(name, val);
        }
        public void Parameters(string name, DateTime val)
        {
            objSqlCommand.Parameters.AddWithValue(name, val);
        }
        public void Parameters(string name, Boolean val)
        {
            objSqlCommand.Parameters.AddWithValue(name, val);
        }
         public void Parameters(string name, int val)
        {
            objSqlCommand.Parameters.AddWithValue(name, val);
        }
        public object ExecuteNonQuery()
        {
            return objSqlCommand.ExecuteNonQuery();
        }
        public void Parameters(string name, SqlDbType type)
        {
            objSqlCommand.Parameters.Add(name, type);
            objSqlCommand.Parameters[name].Direction = ParameterDirection.Output;
        }
        public string Parameters(string name)
        {
            return objSqlCommand.Parameters[name].Value.ToString();
        }
        /// <summary>
        /// Usage = Creates a new command object 
        /// </summary>
        public void CreateCommandObject()
        {
            objSqlCommand = objConnection.CreateCommand();
            objSqlCommand.CommandText = procName;
            objSqlCommand.CommandType = CommandType.StoredProcedure;

        }       
        public DataTable FillDataTable()
        {    
            objDataTable = new DataTable();
            objSqlCommand.CommandText = procName;
            objSqlCommand.Connection = objConnection;
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objDataTable.Load(objSqlCommand.ExecuteReader());
            objConnection.Close();
            return objDataTable;
        }
        public void AssignCommandObject(System.Data.SqlClient.SqlDataAdapter SDA)
        {
            SDA.SelectCommand = objSqlCommand;
        }

        /// <summary>
        /// Usage = Execuates the stored procedure and returns the number
        /// of rows affected
        /// </summary>
        /// <returns></returns>
        public int Execute()
        {
            return (int)objSqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Usage = Executes the stored procedure and returns data reader
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ExecuteDataReader()
        {
            return objSqlCommand.ExecuteReader();
        }

        /// <summary>
        /// Executes the stored procedure and returns the return value
        /// </summary>
        /// <returns></returns>
        public int ExecuteReturnValue()
        {
            objSqlCommand.ExecuteNonQuery();
            return (int)objSqlCommand.Parameters["@retVal"].Value;
        }

        /// <summary>
        /// Usage = Executes the stored procedure and returns data reader
        /// </summary>
        /// <returns></returns>
        public object ExecuteScalerQuery()
        {
            return objSqlCommand.ExecuteScalar();
        }

        /// <summary>
        /// Closes the database connection
        /// </summary>
        public void CloseConnection()
        {
            if (objConnection != null)
                objConnection.Close();
        }

        public void Dispose()
        {
            if (objConnection != null)
            {
                objConnection.Dispose();
                objConnection = null;
            }
        }       
    }
}