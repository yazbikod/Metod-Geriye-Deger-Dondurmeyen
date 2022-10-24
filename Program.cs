Console.WriteLine("Metodlar");
selamVer();
adiniYazdir();
toplamaYap(5, 7);
carpmaYap(5, 8, 2);
adsoyadYazdir("Murat", "Han");
    
    
  static void selamVer()
{
    Console.WriteLine("Selam Arkadaşlar, Kanalımıza Hoşgeldiniz...");
}
static void adiniYazdir()
{
    Console.WriteLine("Ben ; Murat Han HOLOZLU");
}
static void toplamaYap(int sayi1, int sayi2)
{
    Console.WriteLine("Gönderilen sayıların toplamı: " + (sayi1 + sayi2));
}
static void carpmaYap(int sayi1, int sayi2, int sayi3)
{
    Console.WriteLine("Gönderilen sayıların Çarpımı : " + (sayi1 * sayi2 * sayi3));
}
static void adsoyadYazdir(string ad, string soyad)
{
    Console.WriteLine("Kullanıcının Adı ve Soyadı : " + ad + " " + soyad);
}