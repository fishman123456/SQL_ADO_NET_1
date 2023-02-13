//using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

//SqlConnection conn = null;
string sqlSourse  = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library; Integrated Security=true;";
//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False
SqlConnection conn = new SqlConnection(sqlSourse);

conn.Open();
//Console.WriteLine("Введите имя автора");

string insertString = @"insert into Authors Values ('44','ff')";

SqlCommand insertdata = new SqlCommand(insertString, conn);
insertdata.ExecuteNonQuery();

conn.Close();
