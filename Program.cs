
using Microsoft.Data.SqlClient;

//SqlConnection conn = null;
string sqlSourse  = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library; Integrated Security=true;";
//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False
SqlConnection conn = new SqlConnection(sqlSourse);

conn.Open();
//Console.WriteLine("Введите имя автора");
//string select = @"select* from Authors ";
//string insertString = @"insert into Authors Values ('44','ff')";
string insertString = @"insert into Books Values (1,'war',55,455)";

//SqlCommand insertdata = new SqlCommand(insertString, conn);

SqlCommand comm = new SqlCommand(insertString, conn);

SqlDataReader reader = comm.ExecuteReader();

//insertdata.ExecuteNonQuery();
//string select = @"select* from Books ";
//SqlCommand cmd = new SqlCommand(select, conn);
 Console.WriteLine(" ");

    conn.Close();

