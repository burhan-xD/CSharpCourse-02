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

// Collections - Eleman sayılarında genişleme  yapılabilir.
                                // 0         1       2          3
string[] names = new string[] { "Engin", "Gürkan", "Kader", "İrem" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

//names[4] = "Halit"; // Unhandled exception. Array'lerde tanımlanmış sayıların dışına çıkılamaz.

//Console.WriteLine(names[4]); // Unhandled exception.

Console.WriteLine("-----------------");

List<string> names02 = new List<string>();
names02.Add("Engin");

List<String> names03 = new List<String> { "Engin", "Özgür", "Hazal" };
Console.WriteLine(names03[2]);

foreach (string name in names03)
{
    Console.WriteLine(name);
}

Console.WriteLine("-----------------");

names03.Add("Gökçe");
names03.Add("Fatih");

foreach (string name in names03)
{
    Console.WriteLine(name);
}