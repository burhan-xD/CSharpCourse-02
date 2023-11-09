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

// type safe | tip güvenliği olan bir dildir
// Do not repeat yourself!!!

//yer tutucu - alias

string categoryTag = "Kategoriler";
int studentCount = 32000;
//bool isLogin = false;
bool isLogin = true;

double dolarOld = 28.5;
double dolarNew = 29.0;

if (dolarOld > dolarNew)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarOld < dolarNew)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}


if (isLogin == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap butonu");
}


Console.WriteLine("*************************");
Console.WriteLine(categoryTag);
Console.WriteLine(categoryTag);
Console.WriteLine(categoryTag);
Console.WriteLine(categoryTag);
Console.WriteLine(categoryTag);