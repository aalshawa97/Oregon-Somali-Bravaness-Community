using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace Lab4WebApplication
{

    public partial class Background : System.Web.UI.Page
    {
        static private string GetConnectionString()
        {
            return "Data Source=(localdb)\\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        string connectionString = GetConnectionString();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            if(IsPostBack)
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();
                string checkUser = "";
                SqlCommand com = new SqlCommand(checkUser, conn);
                //com.ExecuteScalar() = "";
                //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                /*
                if(temp == 1)
                {
                    conn.Open();
                    string checkPasswordQuery = "";
                    SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                    string password = passComm.ExecuteScalar().ToString();
                    if(password == TextBoxPassword.Text)
                    {

                    }
                    
                }
                */
            }
        }

        //[Test]
        public void ShouldNotAuthenticateUserWithInvalidPassword()
        {
            //IMyMockDa mockDa = new MockDataAccess();
        }
        /*
        public int GetSomeProdId()
        {
            int count = 0;
        }
        */

        //Used for getting a single integer data
        public static int GetID(string SelectStatement)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User Id=user123;Password=123;");
            con.Open();
            SqlCommand com = new SqlCommand(SelectStatement, con);
            int id = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return id;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

                //string connectionString = connectionString = (ConfigurationManager.ConnectionStrings["conStrAbdullah"].ConnectionString);
                // removed Persist Security Info=True; 
                DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
                //Throws
                //csb.ConnectionString = "Data Source = (local)\sqle2018; initial Catalog = LoginDB; integrated Security = True; User ID = user1; Password = 123;";
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User Id=user123;Password=123;"))
                 {
                    if (con.State == ConnectionState.Closed)
                    {
                        string query = "SELECT COUNT(1) from tblUser WHERE username='user123' and password='123'";
                        //string query = "SELECT COUNT(1) from dbo.tblUser";
                        SqlCommand  sqlCmdSelect = new SqlCommand(query, con);
                        txtUserName.Text = "user123";
                        txtPassword.Text = "123";
                        sqlCmdSelect.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                        sqlCmdSelect.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        con.Open();
                        //Execute scalar only gets the first row and column for the query results
                        //int count = (Int32)(sqlCmdSelect.ExecuteScalar());
                        query = "UPDATE tblUser SET username = 'Sakawadin Ahmed Noor' WHERE userid = 0";
                        SqlCommand sqlCmdUpdate = new SqlCommand(query, con);
                        //int effectedRow = sqlCmdUpdate.ExecuteNonQuery();
                        con.Close();
                        /*
                       if(count == 1)
                       {
                           Session["username"] = txtUserName.Text.Trim();
                           Response.Redirect("Dashboard.aspx");
                       }
                       else
                       {
                           lblErrorMessage.Visible = true;
                       }
                       */

                }

                //Close the database connection
                con.Close();
            }
            

        }

        public static void ExecuteReader()
        {
            string query = "SELECT COUNT(1) from tblUser WHERE username='user123' and password='123'";

            using (SqlConnection con = new SqlConnection(query))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM tblUser ", con))
                {
                    cmd.Parameters.AddWithValue("@ID", "0");
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string userName = (string)reader["Username"];
                            string passWord = (string)reader["Password"];
                            Console.WriteLine($"{userName}\n{passWord}");
                        }
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CreateAccount(object sender, EventArgs e)
        {

        }

        /*
        public static int SaveTest(Test newTest)
        {
            var conn = DBConnect.Connection();
        }

        
        public static void SqlDataAdapter()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntern=ReadWrite;MultiSubnetFailover=False;User Id=user123;Password=123;"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("Select Username, Password FROM tblUser", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ID", "UserID");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //myDataGridView.DataSource = dt;
                }
            }
        }
        */
    }
}