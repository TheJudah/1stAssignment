using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// summary for DataClass
/// </summary>
public class BooksAndAuthors
{
    //connects to the database
    SqlConnection connect;

    public BooksAndAuthors()
    {
        connect = new SqlConnection(ConfigurationManager
            .ConnectionStrings["BookReviewDbConnectionString"].ToString() );
    }
    /// <summary>
    /// Called in aspx.cs file.
    /// gets authors and fills dropdown
    /// </summary>
    /// <returns>DataTable witn names of authors</returns>
    public DataTable GetAuthors()
    {
        //sql command
        string sql = 
            "SELECT AuthorKey, AuthorName FROM Author ORDER BY authorname";
        //new datatable object
        DataTable table;
        //Connects to db
        SqlCommand cmd = new SqlCommand(sql, connect);
        try
        {
            //execute the sql command. Store result in table.
            table = ProcessQuery(cmd);
        } catch(Exception excep)
        {
            //Error!
            throw excep;
        }
        //return table
        return table;
    }

    public DataTable GetBooksByAuthor(int authorKey)
    {
        DataTable table = null;
        //SQL command
        String sql = " SELECT * FROM book " +
            " INNER JOIN authorbook " +
            " ON book.bookkey = authorbook.bookkey " +
            " WHERE authorkey = @authorkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        //put variable into sql
        cmd.Parameters.AddWithValue("@authorkey", authorKey);
        try
        {
            table = ProcessQuery(cmd);
        } catch (Exception ex)
        {
            throw ex;
        }
        return table;
    }

    private DataTable ProcessQuery(SqlCommand cmd)
    {
        //table to hold data
        DataTable table = new DataTable();
        //object to read database
        SqlDataReader reader;
        try
        {
            //connects to server
            connect.Open();
            //execute
            reader = cmd.ExecuteReader();
            //put data in the table
            table.Load(reader);
            //ccose connection and reader
            connect.Close();
            reader.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return table;
    }
}
