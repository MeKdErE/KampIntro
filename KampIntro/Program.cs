// See https://aka.ms/new-console-template for more information
string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Propgramlamaya başlangıç için temel kurs",
    "Java","Python", "C#"};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar) 
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu - Footer");