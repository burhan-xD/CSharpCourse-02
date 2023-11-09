using OOP03;
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

ILoanManager generalPurposeLoanManager = new GeneralPurposeLoanManager();
ILoanManager autoLoanManager = new AutoLoanManager();
ILoanManager homeLoanManager = new HomeLoanManager();

ILoggerService fileLoggerService = new FileLoggerService();

ApplyManager applyManager = new ApplyManager();
//applyManager.ApplyNow(generalPurposeLoanManager);
//applyManager.ApplyNow(homeLoanManager);
applyManager.ApplyNow(autoLoanManager, new DatabaseLoggerService()); // içeride new ile yapılabilir
Console.WriteLine("____________________________");
applyManager.ApplyNow(homeLoanManager, fileLoggerService); // dışarıda new ile yapılabilir line: 32
Console.WriteLine("____________________________");
applyManager.ApplyNow(new GroceryLoanManager(), new SmsLoggerService());

List<ILoanManager> loans = new List<ILoanManager>()
{ 
    autoLoanManager,
    homeLoanManager,
};

//applyManager.LoanDisclosureDo(loans);


//GeneralPurposeLoanManager generalPurposeLoanManager = new GeneralPurposeLoanManager();
//generalPurposeLoanManager.Calculate();

//AutoLoanManager autoLoanManager = new AutoLoanManager();
//autoLoanManager.Calculate();

//HomeLoanManager homeLoanManager = new HomeLoanManager();
//homeLoanManager.Calculate();

Console.WriteLine("____________________________");

// interface kendisini implement eden class'ın referansını tutabilir. 

//ILoanManager generalPurposeLoanManager02 = new GeneralPurposeLoanManager();
//generalPurposeLoanManager.Calculate();

//ILoanManager autoLoanManager02 = new AutoLoanManager();
//autoLoanManager.Calculate();

//ILoanManager homeLoanManager02 = new HomeLoanManager();
//homeLoanManager.Calculate();

//Console.WriteLine("____________________________");

