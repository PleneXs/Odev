using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bilgileri al
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadınızı girin: ");
        string soyad = Console.ReadLine();

        Console.Write("Öğrenci numaranızı girin: ");
        string ogrenciNo = Console.ReadLine();

        Console.Write("Cep telefonunuzu girin: ");
        string cepTel = Console.ReadLine();

        // Bilgileri konsola yazdır
        Console.WriteLine("\n--- Kullanıcı Bilgileri ---");
        Console.WriteLine($"Ad: {ad}");
        Console.WriteLine($"Soyad: {soyad}");
        Console.WriteLine($"Öğrenci No: {ogrenciNo}");
        Console.WriteLine($"Cep Telefonu: {cepTel}");
    }
}
