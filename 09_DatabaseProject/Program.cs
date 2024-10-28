using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ado.net

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;

			Console.WriteLine("----------------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("----------------------------------");

			SqlConnection connection = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"); // Bağlantı oluşturuldu.
			connection.Open();// Bağlantıyı açtık.
			SqlCommand command = new SqlCommand("select * from TblCategory", connection);// Sorgu yazdık.
			SqlDataAdapter adapter = new SqlDataAdapter(command); // C# da yazdığımız sorgu ile veri tabanı arasında bağlantı sınıfıdır.
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable); // yukarıda yazdığımız sorguyu ram bellek üzerine aldık.
			connection.Close();

			foreach (DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine();	
			}

			Console.Read();
		}
	}
}
