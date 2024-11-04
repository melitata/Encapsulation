using System;

public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int kapıSayisi;
    public int KapıSayisi
    {
        get { return kapıSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                kapıSayisi = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı Sayısı sadece 2 veya 4 olabilir. Kapı Sayısı -1 olarak atandı.");
                kapıSayisi = -1;
            }
        }
    }

    public Araba(string marka, string model, string renk, int kapıSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayisi = kapıSayisi; 
    }

    // Araba bilgilerini yazdırma metodu
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapıSayisi}");
    }
}

// Program sınıfı ile giriş noktası
class Program
{
    static void Main()
    {
        // Kapı Sayısı 4 olan geçerli bir Araba nesnesi
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        araba1.BilgileriYazdir();

        // Kapı Sayısı 3 olan geçersiz bir Araba nesnesi
        Araba araba2 = new Araba("Honda", "Civic", "Siyah", 3);
        araba2.BilgileriYazdir();
    }
}
