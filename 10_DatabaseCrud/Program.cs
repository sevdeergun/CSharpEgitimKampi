﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud->Create->Read->Update->Delete
            Console.WriteLine("***Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("----------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");

            //Console.Read();

            #endregion Ürün Ekleme İşlemi


            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.WriteLine("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.WriteLine("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);


            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı");



            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion


            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@productID", connection);

            //command.Parameters.AddWithValue("@productId", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source =SEVDE\\SQLEXPRESS; initial catalog= DbEgitimKampi ; integrated security=true"); //SQL'e bağlanmak için
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion






        }
    }
}
