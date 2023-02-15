
using Microsoft.Data.SqlClient;

//SqlConnection conn = null;

// строка соединение
string sqlSourse  = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library; Integrated Security=true;";
//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False
//открываем соединение
SqlConnection conn = new SqlConnection(sqlSourse);

conn.Open();
//Console.WriteLine("Введите имя автора");
//string select = @"select* from Authors ";
//string insertString = @"insert into Authors Values ('44','ff')";
string insertString = @"insert into Books Values (1,'war',55,455)";

int indexautor = 2;
string bookname = "Oshen";
int bookprise = 300;
int page = 1205;
// описываем каждый параметр

SqlParameter param1 = new SqlParameter();
param1.ParameterName = "AuthorId";
param1.SqlDbType = System.Data.SqlDbType.VarChar;
param1.Value = indexautor;

SqlParameter param2 = new SqlParameter();
param2.ParameterName = "Title";
param2.SqlDbType = System.Data.SqlDbType.VarChar;
param2.Value = bookname;

SqlParameter param3 = new SqlParameter();
param2.ParameterName = "PRICE";
param2.SqlDbType = System.Data.SqlDbType.Int;
param2.Value = bookprise;

SqlParameter param4 = new SqlParameter();
param2.ParameterName = "PAGES";
param2.SqlDbType = System.Data.SqlDbType.Int;
param2.Value = page;

//SqlCommand insertdata = new SqlCommand(insertString, conn);

SqlCommand comm = new SqlCommand(insertString, conn);

SqlDataReader reader = comm.ExecuteReader();

//insertdata.ExecuteNonQuery();
//string select = @"select* from Books ";
//SqlCommand cmd = new SqlCommand(select, conn);
 Console.WriteLine(" ");

    conn.Close();

