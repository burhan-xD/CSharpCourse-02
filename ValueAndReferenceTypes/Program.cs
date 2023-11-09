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

int z = 30;
int y = 55;

z = y;
// y = ? => 55
// z = ? => 55

Console.WriteLine(z);
Console.WriteLine(y);

int[] x = new int[] { 5, 10, 15, 20 };
int[] v = new int[] { 4, 8, 12, 16  };

x = v;
v[0] = 6;

// x[0] = ? => 6    // x = v dendiği an x'in ilk atamadaki değerleri boşa düşer. x artık v'nin değerlerini gösterir
// v[0] = ? => 6    // dolayısıyla v'nin değerlerinde yapılan değişiklik x'i etkiler.

Console.WriteLine("x\n_______________");
foreach (var item in x)
{
    Console.WriteLine(item);
}
Console.WriteLine("###############");
Console.WriteLine("v\n________________");
foreach (var item in v)
{
    Console.WriteLine(item);
}