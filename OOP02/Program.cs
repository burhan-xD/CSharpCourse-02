#region burhan-xD Main


using OOP02;

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

// Tüzel müşteriler ile gerçek müşterilerin özellikleri aynı class altında olmamalı. companyName tüzel müşteriye ait!
// Tüzel ve Gerçek Müşteri - SOLİD -> L
// Base class referans tutucudur. Customer

IndividualCustomer customer01 = new IndividualCustomer
{
    Id = 1,
    FirstName = "Engin",
    LastName = "Demiroğ",
    TcNo = "12343221343221423",
    CustomerNo = "45632",
};

CorporateCustomer customer02 = new CorporateCustomer
{
    CompanyName = "İstanbul Kodluyor",
    CustomerNo = "654654",
    VergiNo = "4568989798797979",
    Id = 9,
};

Customer customer03 = new IndividualCustomer();
Customer customer04 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer01);
customerManager.Add(customer02);
customerManager.Add(customer03);
customerManager.Add(customer04);
