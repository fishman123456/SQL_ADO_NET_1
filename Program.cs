
using Microsoft.Data.SqlClient;

//SqlConnection conn = null;
//создание строки для соединения с сервером
string sqlSourse = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library; Integrated Security=true;";

// передача строки для открытия соединения
SqlConnection conn = new SqlConnection(sqlSourse);

// открытие соединения
conn.Open();

//Console.WriteLine("Введите имя автора");
//string select = @"select* from Authors ";

// создание запроса, добавляем данные
//string insertString = @"insert into Authors Values ('44','ff')";
string insertString = @"insert into Books Values (1,'war',55,455)";

// создаём команду (запрос, строка соединения с базой данных)
SqlCommand insertdata = new SqlCommand(insertString, conn);

//SqlCommand comm = new SqlCommand(insertString, conn);
//SqlDataReader reader = comm.ExecuteReader();

// выполняем комманду
insertdata.ExecuteNonQuery();

//string select = @"select* from Books ";
//SqlCommand cmd = new SqlCommand(select, conn);
//Console.WriteLine(" ");

// закрываем соединение
conn.Close();

