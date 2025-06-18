
List<int> sayilar = new List<int> { 5, 10, 18, -27, 58, 127, 560, -33, 72, 94 };

var ciftSayilar = sayilar.Where(x => x % 2 == 0);
Console.WriteLine("Çift sayılar:");

foreach (var item in ciftSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------");
var tekSayilar = sayilar.Where(x => x % 2 == 1);
Console.WriteLine("Tek sayılar:");

foreach (var item in tekSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------");

var negatifSayilar = sayilar.Where(x => x < 0);
Console.WriteLine("Negatif sayılar:");

foreach (var item in negatifSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------");

var pozitifSayilar = sayilar.Where(x => x > 0);
Console.WriteLine("Pozitif sayılar:");

foreach (var item in pozitifSayilar)
{ 
    Console.WriteLine(item); 
}
Console.WriteLine("---------------------");

var karsilastirmaliSayilar = sayilar.Where(x => x > 15 && x < 22);
Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");

foreach (var item in karsilastirmaliSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------");

List<int> kareHesapListesi = new List<int> { 1, 3, 5, 8, 12, 17, 22, 36, 49, 51 };

int KareHesapla(int sayi)
{
    return sayi * sayi;
}

Console.WriteLine("Listedeki sayıların karesi: ");
foreach (var item in kareHesapListesi)
{
    Console.WriteLine(KareHesapla(item));
}






