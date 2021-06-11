namespace Lab4WebApplication.Tests.Controllers
{
    /*
    [TestClass]
    public class UserControllerTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
        }
        public static int SaveTest(Test newTest)
        {
            var conn = DbContext.Connection();
            const string sqlString = "INSERT INTO dbo.Tests ( Tester , Premise ) " +
                                     "               VALUES ( @tester , @premise ) " +
                                     "SELECT SCOPE_IDENTITY()";
            using (conn)
            {
                using (var cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@tester", newTest.tester);
                    cmd.Parameters.AddWithValue("@premise", newTest.premise);

                    cmd.CommandType = "SELECT";
                    conn.Open();
                    return (int) (decimal) cmd.ExecuteScalar();

                }
            }
        }
        
    }
    */
}
