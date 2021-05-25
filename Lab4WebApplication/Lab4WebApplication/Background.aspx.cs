using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Lab4WebApplication
{
    public partial class Background : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //string connectionString = connectionString = (ConfigurationManager.ConnectionStrings["conStrAbdullah"].ConnectionString);
            // removed Persist Security Info=True; 
            string connectionString = @"Data Source=LAPTOP-E4UQ9M0E\15039;Initial Catalog=Demodb;User ID=sa;Password=demol23";

            if (connectionString != null || connectionString != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                }
            }

        }
    }
}