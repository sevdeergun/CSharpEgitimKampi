using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net //C#'ta SQL'i kullanabilmemizi sağlayan bir framework
            Console.WriteLine("**C# Veri Tabnalı Ürün-Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------");
            Console.WriteLine("1-Kategoeriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------");

            SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial Catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //Tablonun hangi veri tabanıyla olduğunu bildirmek için
            SqlDataAdapter adapter = new SqlDataAdapter(command); //SQL'le köprü görevi gören komut
            DataTable dataTable = new DataTable(); //Verileri geçici belleğe almayı sağlar.
            adapter.Fill(dataTable);

            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();






        }
    }
}
