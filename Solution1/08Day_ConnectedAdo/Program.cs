using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _08Day_ConnectedAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =" Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = dac03; Integrated Security = True";

            #region Select Query
            //SqlConnection conn = new SqlConnection(connectionString);
            //string selectQuery = "Select  * from Student";


            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType=System.Data.CommandType.Text;
            //cmd.CommandText=selectQuery;
            //cmd.Connection = conn;

            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) {
            //    int rollnum = Convert.ToInt32(reader["rollno"]);
            //    string? name = Convert.ToString(reader["name"]);
            //    int marks = Convert.ToInt32(reader["marks"]);
            //    Console.WriteLine($"RollNo: {rollnum}, Name: {name}, Marks: {marks}");
            //}

            //conn.Close(); 
            #endregion

            #region InsertQuery
            //SqlConnection conn =new SqlConnection(connectionString);
            //Console.WriteLine("Enter your RollNumber");
            //int rollno = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your name");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter your Marks");
            //int marks = Convert.ToInt32(Console.ReadLine());


            //string insertQuery = $"insert into Student(rollno,name,marks) values('{rollno}','{nm}','{marks}')";

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText= insertQuery;
            //cmd.Connection = conn;

            //conn.Open();
            //int noRowsAffected=cmd.ExecuteNonQuery();
            //if (noRowsAffected > 0) {
            //    Console.WriteLine("Record Inserted Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Unable to add the record");
            //} 
            #endregion

            #region UpdateQuery
            //SqlConnection con = new SqlConnection(connectionString);
            //Console.WriteLine("Enter you roll number");
            //int roll=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your Updated marks");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //string updateQuery = $"update Student set name ={marks} where rollno={roll}";
            //SqlCommand cmd = new SqlCommand(updateQuery,con);

            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record updated successfully!!");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            //con.Close(); 
            #endregion

            #region Delete Query
            //SqlConnection con = new SqlConnection(connectionString);
            //Console.WriteLine("Enter the roll Number to delete");
            //int roll = Convert.ToInt32(Console.ReadLine());

            //string DeleteQuery = $"Delete from Student where rollno = {roll}";

            //SqlCommand cmd = new SqlCommand(DeleteQuery, con);

            //con.Open();

            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("Deleted Record Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Unable to delete the record");
            //}

            //    con.Close(); 
            #endregion

        }
    }
}
