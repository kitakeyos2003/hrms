using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Database
{
    private static Database instance = new Database();
    public static Database GetInstance() { return instance; }

    private SqlConnection connection = null;
    private string dataSource = "DESKTOP-BKGVNFJ";
    private string databaseName = "QLBH";
    private string username = "";
    private string password = "";

    public void Connect()
    {
        if (connection != null)
        {
            return;
        }
        try
        {
            string connectionString = "Data Source=" + dataSource + "; Initial Catalog=" + databaseName + "; Integrated Security=True";

            SqlConnection connection;
            if (username != null && !username.Equals(""))
            {
                SecureString securePassword = new SecureString();
                foreach (char c in password)
                {
                    securePassword.AppendChar(c);
                }
                securePassword.MakeReadOnly();
                SqlCredential credential = new SqlCredential(username, securePassword);
                connection = new SqlConnection(connectionString, credential);
            }
            else
            {
                connection = new SqlConnection(connectionString);
            }
            connection.Open();
            this.connection = connection;
        }
        catch (SqlException e)
        {
            MessageBox.Show(e.Message.ToString(), "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public SqlConnection GetConnection()
    {
        return this.connection;
    }

    public void Close()
    {
        if (connection != null)
        {
            connection.Close();
            connection = null;
        }
    }
}
