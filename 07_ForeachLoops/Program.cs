using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			//Foreach(1;2;3;4)

			//1:Değişken türü
			//2:Değişken adi
			//3:in
			//4:liste, koleksiyon, dizi

			//string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

			//foreach (string city in cities)
			//{
			//	Console.WriteLine(city);
			//}

			//int[] numbers = { 12, 56, 87, 123, 694, 456, 7300, 5296, 461, 580, 37, 73 };

			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//int[] numbers = { 12, 56, 87, 123, 694, 456, 7300, 5296, 461, 580, 37, 73 };

			//foreach(int number in numbers)
			//{
			//	if(number % 2 == 0)
			//	{
			//		Console.WriteLine(number);
			//	}
			//}

			//int[] numbers = { 12, 56, 87, 123, 694, 456, 7300, 5296, 461, 580, 37, 73 };

			//int total = 0;

			//foreach(int i in numbers)
			//{
			//	total += i;
			//}
			//Console.WriteLine(total);

			//List<int> numbers = new List<int>()
			//{
			//	1, 2, 3, 4, 5, 8
			//};
			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//string word = "Merhaba";

			//foreach(char c in word)
			//{
			//	Console.WriteLine(c);
			//}

			#endregion

			#region Örnek Sınav Sistemi Uygulaması

			//Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();

			////Sınıftaki öğrenci sayısını kullanıcıdan alma
			//Console.WriteLine("------------------------------");
			//Console.Write("Sınıfınızda kaç öğrenci var: ");
			//int studentCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("------------------------------");

			////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler	
			//string[] studentNames = new string[studentCount];
			//double[] studentExamAvg = new double[studentCount];

			//for(int i = 0; i < studentCount; i++)
			//{
			//	Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
			//	studentNames[i] = Console.ReadLine();

			//	double totalExamResult = 0; 


			//	//Her öğrenci için 3 sınav notu girişi

			//	for(int j = 0; j < 3; j++)
			//	{
			//		Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
			//		double value = double.Parse(Console.ReadLine());
			//		totalExamResult += value;//Notları topluyoruz.
			//	}
			//	Console.WriteLine();
			//	studentExamAvg[i] = totalExamResult / 3;
			//}

			////Sınav Ortalamaları
			//for(int i = 0; i < studentCount; i++)
			//{
			//	Console.WriteLine("------------------------------");
			//	Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]:f2}");

			//	if (studentExamAvg[i] >= 50)
			//	{
			//		Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
			//	}
			//	Console.WriteLine("------------------------------");
			//}

			#endregion

			Console.Read();
		}
	}
}
