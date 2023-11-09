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

Kurs kursCSharp = new Kurs();

kursCSharp.Name = "C#";
kursCSharp.Instructor = "Engin";
kursCSharp.CompletionRate = 74;

Kurs kursJava = new Kurs()
{
    Name = "Java",
    Instructor = "Halit",
    CompletionRate = 45,
};

Kurs kursPython = new Kurs() { Name = "Python", Instructor = "İrem", CompletionRate = 89 };

Console.WriteLine(kursCSharp.Name + ": " + kursCSharp.Instructor);
//foreach (var item in kursCSharp) - Olmaz. Dizi değil

Kurs[] kurslar = new Kurs[] {kursCSharp, kursJava, kursPython};

Console.WriteLine("*************************");

Console.WriteLine("Kurs Adı \t Eğitmen \t Tamamlanma Oranı");
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.Name + " \t\t" + kurs.Instructor + "\t\t\t" + kurs.CompletionRate);
    //Console.WriteLine(kurs.Instructor);
    //Console.WriteLine(kurs.CompletionRate);
    //Console.WriteLine("__________");
}

class Kurs
{
    public string Name { get; set; }
    public string Instructor { get; set; }
    public int CompletionRate { get; set; }
}