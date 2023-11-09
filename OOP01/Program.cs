using OOP01;
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


Product product01 = new Product();
product01.Id = 171;
product01.CategoryId = 2;
product01.ProductName = "Masa";
product01.UnitPrice = 144;
product01.UnitInStock = 3;

Product product02 = new Product
{
    Id = 236,
    CategoryId = 5,
    UnitInStock = 5,
    UnitPrice = 122,
    ProductName = "Kalem",
};

//PascalCase    //camelCase => Class'lar PascalCase ile isimlendirmesi yapılır
ProductManager productManager01 = new ProductManager();

productManager01.Add(product01);
Console.WriteLine("------------------");
productManager01.Add(product02);