int time = DateTime.Now.Hour;

if (time >= 6 && time <11)
Console.WriteLine("Günaydın");
else if(time <=18)
Console.WriteLine("İyi Günler");
else
Console.WriteLine("İyi geceler");
string sonuc = time <=18 ? "İyi Günler" : "İyi Geceler";
System.Console.WriteLine(sonuc);
sonuc = time >= 6 && time <=11 ? "Günaydın" : time <= 18 ? "İyi günler" : "Yat artık";
System.Console.WriteLine(sonuc);