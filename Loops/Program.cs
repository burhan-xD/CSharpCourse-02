#region burhan-xD Main
static void DarkBlueText()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
}
static void YellowText()
{
    Console.ForegroundColor = ConsoleColor.Yellow; ;
}
//Console.WriteLine("********* Hello World... xD *********");
Console.Title = "burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*****************************************");
Console.Write("*********"); DarkBlueText(); Console.Write(" istanbulKodluyor - C# "); YellowText(); Console.WriteLine("*********");
Console.Write("*********"); DarkBlueText(); Console.Write(" github.com/burhan-xD "); YellowText(); Console.WriteLine("**********");
Console.WriteLine("*****************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("_________________________________________");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

#endregion


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("*************************");
//for (int i = 1; i <= 10; i+=2)
//{
//    Console.WriteLine(i);
//}

string kurs01 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs02 = "Programlamaya Başlangıç İçin Temel Kurs";
string kurs03 = "Java";

// array - dizi

string[] kurslar = new string[] {
    "Yazılım Geliştirici Yetiştirme Kampı",
    "Programlamaya Başlangıç İçin Temel Kurs",
    "Java",
    "C#",
    "Python"};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("*************************\n");
Console.WriteLine("Foreach\n_______");

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}
