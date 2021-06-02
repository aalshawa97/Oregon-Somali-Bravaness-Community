using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab4WebApplication.Models;
using Microsoft.VisualStudio.Services.Account;
using Lab4WebApplication.Data.Entities;
//using MVCLogin.Models;

namespace Lab4WebApplication.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        //GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //GET: Account
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source= LAPTOP-E4UQ9MOE; database=WPF; integrated security = SSPI";
        }
        [System.Web.Http.HttpPost]
        public ActionResult Autherize(User acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tblUser where UserName='" + acc.UserName + "' and password ='"+ acc.Password + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
        }
        
        public object LoginControl { get; private set; }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //public ActionResult Details(int id)
        //{
            //var user = GetUser(id);
            ///return View(user);
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        protected void LoginControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool authenticated = false;// this.ValidateCredentials(LoginControl.UserName, LoginControl.Password);
            if (authenticated)
            {
                //FormsAuthentication.RedirectFromLoginPage(LoginControl.UserName, LoginControl.Password);
            }
        }
        /*
        

        public bool IsAlphaNumeric(string text)
        {
            return Regex.IsMatch(text, "^[a-zA-Z0-9]+$");
        }
        private bool ValidateCredentials(object userName, object password)
        {
            bool returnValue = false;
            if (this.IsAlphaNumeric(userName) && userName.Length <= 50 && password.Length <= 50)
            {
                if (this.IsAlphaNumeric(userName) && userName.Length <= 50 && password.Length <= 50)
                {
                    SqlConnection conn = null;
                    try
                    {
                        string sql = "select count(*) from users where username = @username and password = @password"; conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MembershipSiteConStr"].ConnectionString); SqlCommand cmd = new SqlCommand(sql, conn); SqlParameter user = new SqlParameter(); user.ParameterName = "@username"; user.Value = userName.Trim(); cmd.Parameters.Add(user); SqlParameter pass = new SqlParameter(); pass.ParameterName = "@password"; pass.Value = Hasher.HashString(password.Trim()); cmd.Parameters.Add(pass); conn.Open(); int count = (int)cmd.ExecuteScalar(); if (count > 0) returnValue = true;
                    catch (Exception ex)
                    {
                        //Log your error
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                //Log error - user name not alpha-numeric or username or password exceed the length limit!
            }
            return returnValue;
        }
        */
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}