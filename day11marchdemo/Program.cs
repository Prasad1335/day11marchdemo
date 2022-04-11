



//Console.WriteLine("-------------------------------");
//Console.WriteLine("  ** Find Gretest Number **   ");
//Console.WriteLine("-------------------------------");

//Console.Write("      1. enter number : > ");
//int number1 = int.Parse(Console.ReadLine());

//Console.Write("      2. enter number : > ");
//int number2 = int.Parse(Console.ReadLine());

//Console.Write("      3. enter number : > ");
//int number3 = int.Parse(Console.ReadLine());

//Console.WriteLine("-------------------------------");

//if (number1 > number2)
//{
//    if (number1 > number3)
//    {
//        Console.WriteLine("  Ans : " + number1 + " : is gretest number");
//    }
//    else
//    {
//        Console.WriteLine("  Ans : " + number3 + " : is gretest number");
//    }
//}
//else if (number2 > number3)
//{
//    Console.WriteLine("  Ans : " + number2 + " : is gretest number");
//}
//else
//{
//    Console.WriteLine("  Ans : " + number3 + " : is gretest number");
//}



//Console.WriteLine("-----------------------------------------------");
//Console.Write("   Enter 1 to 7 number to check the day name  : > ");


//int day =int.Parse(Console.ReadLine());
//if (day == 1)
//{
//    Console.WriteLine("  > Monday");
//}
//else if (day == 2)
//{
//    Console.WriteLine("  > Tuesday");
//}
//else if(day == 3)
//{
//    Console.WriteLine("  > Wednesday");
//}
//else if (day == 4)
//{
//    Console.WriteLine("  > Thursday");
//}
//else if (day == 5)
//{
//    Console.WriteLine("  > Friday");
//}
//else if (day == 6)
//{
//    Console.WriteLine("  > Saturday");
//}
//else if (day == 7)
//{
//    Console.WriteLine("  > Sunday");
//}
//else
//{
//    Console.WriteLine("***   Enter Correct Number Less Than 8   ***");
//}





//Console.WriteLine("-----------------------------------------------");
//Console.WriteLine("  ** print number of day particular month **   ");
//Console.WriteLine("-----------------------------------------------");

//Console.Write("      1. enter month : > ");
//var month = Console.ReadLine().ToLower();


//if (month == "jan" || month == "mar" || month == "may" || month == "jul" || month == "aug" || month == "oct" || month == "dec")
//{
//    Console.WriteLine(" > "+ month + " : Month in Number of days is 31");
//}

//else if (month == "feb")
//{
//    Console.WriteLine(" > " + month + " : Month in Number of days is 28");
//}

//else if (month=="apr" || month == "jun"|| month == "sep" || month == "nov")
//{
//    Console.WriteLine(" > " + month + " : Month in Number of days is 30");
//}
//}




Console.Write("enter number : > ");
double number = double.Parse(Console.ReadLine());

if (number > 0)
{
    if (number < 1)
    {
        Console.WriteLine(" Positive small number");
    }
    else if (number > 1000000)
    {
        Console.WriteLine(" Positive large number");
    }
    else
    {
        Console.WriteLine(" Positive number");
    }
}
else if (number < 0)
{
    if (number < 0)
    {
        Console.WriteLine(" negative small number");
    }
    else if (number > 1000000)
    {
        Console.WriteLine(" negative large number");
    }
    else
    {
        Console.WriteLine(" negative number");
    }
}
else
{
    Console.WriteLine(" Zero");

}






