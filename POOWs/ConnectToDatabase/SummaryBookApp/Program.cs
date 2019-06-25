using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            List<int> bookYears = new List<int>();
            string maxYearBook;
            List<Book> topBoks = new List<Book>();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C6SIFK8;Initial Catalog=Librar;Integrated Security=True"))
            {
                conn.Open();
                var command = "select Title from Book where Year = 2010;";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            books.Add((string)rdr["Title"]);
                        }
                    }
                }
  
                using (SqlCommand cmd = new SqlCommand("select Year from book;", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            bookYears.Add((int)rdr["Year"]);
                        }
                    }
                }
                
                using (SqlCommand cmd = new SqlCommand("select Title from book where Year = @MaxYear", conn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@MaxYear";
                    param.Value = bookYears.Max();

                    cmd.Parameters.Add(param);

                    maxYearBook = cmd.ExecuteScalar().ToString();        
                }

                using (SqlCommand cmd = new SqlCommand("select top 10 Title, Year, Price from Book", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            Book book = new Book((string)rdr["Title"], (int)rdr["Year"], (decimal)rdr["Price"]);
                            topBoks.Add(book);
                        }
                    }
                }
            }

            Console.WriteLine("Book of Year 2010: ");
            PrintList(books);
            Console.WriteLine("Max Year book: " + maxYearBook);

            Console.WriteLine("Top 10 Books: ");
            foreach(Book b in topBoks)
            {
                Console.WriteLine($"Title: {b.Title}, Year: {b.Year}, Price: {b.Price}");
            }
        }

        static void PrintList(List<string> ls)
        {
            foreach(string s in ls)
            {
                Console.WriteLine(s + " ");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Book(string title, int year, decimal price)
        {
            Title = title;
            Year = year;
            Price = price;
        }
    }

}
