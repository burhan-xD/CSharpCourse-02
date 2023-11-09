using Methods;
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


// Dont repeat yourself - DRY
// Clean Code | best Practice


Product product01 = new Product();
product01.Name = "Elma";
product01.Description = "Amasya Elması";
product01.Price = 56;

Product product02 = new Product();
product02.Name = "Portakal";
product02.Description = "Diyarbakır Karpuzu";
product02.Price = 40.05;

Product[] products = new Product[] { product01, product02 };
         //var kullanılabilir
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("-------------");
}

Console.WriteLine("-------------");
BasketManager basketManager = new BasketManager();

basketManager.Add(product02);
basketManager.Add02("Mandalina", "Akdeniz", 16.8, 885);