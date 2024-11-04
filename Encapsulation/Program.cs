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

   
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapıSayisi}");
    }
}


