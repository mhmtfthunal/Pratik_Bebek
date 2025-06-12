using Pratik_Bebek;

Bebek bebek = new Bebek()
{
    Ad = "Fatih",
    SoyAd = "Unal",
    DogumTarihi = DateTime.Now,
};

Console.WriteLine("Bebeğin Bilgileri:" +" "+ bebek.Ad +" "+ bebek.SoyAd);

Bebek bebek2 = new Bebek("Selim", "Kazancı");

Console.WriteLine("İkinci Bebeğin Bilgileri: " + " " + bebek2.Ad + " " + bebek.SoyAd + " " + bebek.DogumTarihi);