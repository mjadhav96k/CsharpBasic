using System;
namespace IntroductionToCsharp
{
    class Program
    {
        #region Introduction
        //static void Main1()
        //{
        //    Console.WriteLine("Welcome to main1 method");
        //}

        //static void Main()
        //{
        //    Console.WriteLine("Welcome to csharp Training!");
        //    Main1();
        //} 
        #endregion

        #region Reading and writing
        //static void Main()
        //{
        //    Console.WriteLine("Please enter your first name");

        //    string firstName = Console.ReadLine();

        //    Console.WriteLine("Please enter your last name");

        //    string lastName = Console.ReadLine();

        //    //Console.WriteLine("Hello " + userName);
        //    // we can use placeholder for same as well.
        //    Console.WriteLine("Hello {0}, {1}", firstName, lastName);
        //}
        #endregion

        #region Built - in Types
        //static void Main()
        //{
        //    // integral data types not include decimals.
        //    int i = 0;
        //    Console.WriteLine("Min value {0}", int.MinValue);
        //    Console.WriteLine("Max value {0}", int.MaxValue);
        //} 
        #endregion

        #region String Type
        //static void Main()
        //{
        //    string name = "\"Mayuresh\""; // escape sequences to treat special charchters as normal if we want to print them.
        //    Console.WriteLine(name);
        //    Console.WriteLine("One\nTwo\nThree");

        //    string path = @"F:\\KudVenkat c#\\Handson";
        //    Console.WriteLine(path); // demo to print path of file to print \ also. we use verbatim literal.
        //} 
        #endregion

        #region Common operators : Ternary 
        //static void Main()
        //{
        //    int number = 10;
        //    bool IsNumber10;

        //    //if(number == 10)
        //    //{
        //    //    IsNumber10 = true;
        //    //}
        //    //else
        //    //{
        //    //    IsNumber10 = false;
        //    //}
        //    //Console.WriteLine("Number == 10 is {0}", IsNumber10);

        //    //this above code can reduce with ternary opertor as follows:

        //    IsNumber10 = number == 10 ? true : false;
        //    //after ? part is true here and after : part is false
        //    Console.WriteLine("Number == 10 is {0}", IsNumber10);
        //} 
        #endregion

        #region Nullable data type.
        //static void Main()
        //{
        //    string name = null;
        //    //int i = null; // not nullable because it is value type
        //    int? i = null; // to make this nullable just put the ? after data type.

        //    bool areYouAdult = true; // but if this optional field then null should be there.
        //    bool? areYouAdult1 = null;
        //    if(areYouAdult1 == true)  //areYouAdult.Value also you can use here
        //    {
        //        Console.WriteLine("User is major");
        //    }
        //    else if (areYouAdult1 == false)
        //    {
        //        Console.WriteLine("user is not major");
        //    }
        //    else
        //    {
        //        Console.WriteLine("user did not anwser the question");
        //    }
        //} 
        #endregion

        #region Null coalescing operator
        //static void Main()
        //{
        //int? ticketsOnSale = null;
        //int availableTickets;

        //if(ticketsOnSale == null)
        //{
        //    availableTickets = 0;
        //}
        //else
        //{
        //    availableTickets = ticketsOnSale.Value; // we have to convert it from nullable to non-nullable by value we can do it or by implicit comversion like (int)ticketsOnSale
        //}
        //Console.WriteLine("Available tickets = {0}", availableTickets);

        // we can do this by different way null coalescing operator
        //    int? ticketsOnSale = 100;
        //    int availableTickets = ticketsOnSale ?? 0;
        //    Console.WriteLine("Available Tickets = {0}", availableTickets);

        //} 
        #endregion

        #region Implicit and explicit Conversion
        //static void Main()
        //{
        //    //int i = 100;
        //    //float f = i;
        //    //Console.WriteLine(f); //implicit conversion

        //    float f = 123.45f;
        //    int i = (int)f;
        //    Console.WriteLine(i); // explicit conversion may occur loss of data using type cast operator

        //    // other way to explicit
        //    int j = Convert.ToInt32(f);
        //    Console.WriteLine(j); // same explicit using Convert class
        //    // good practice is to use Convert class becuase it will throw exception when value is not in range of data type.
        //    // if we use type cast operator it can give number in -2346378 it will try to do conversion and will not throw exception.
        //} 
        #endregion

        #region Parse and TryParse if number is in a string format
        //static void Main()
        //{
        //    string strNumber = "100";
        //    //int i = strNumber; // throws error
        //    int i = int.Parse(strNumber);
        //    Console.WriteLine(i);

        //    string strNumber2 = "100MJ";
        //    int result = 0;
        //    bool IsConversionSuccessful = int.TryParse(strNumber2, out result); //return type of TryParse is boolean.

        //    if (IsConversionSuccessful)
        //    {
        //        Console.WriteLine(result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter valid number");
        //    }
        //} 
        #endregion

        #region Array
        //static void Main()
        //{
        //    int[] arrEvenNumber = new int[3];
        //    arrEvenNumber[0] = 0;
        //    arrEvenNumber[1] = 2;
        //    arrEvenNumber[2] = 4;

        //    Console.WriteLine(arrEvenNumber[1]);
        //} 
        #endregion

        #region Switch Statement
        //static void Main()
        //{
        //    int userNumber = 0;

        //    try
        //    {
        //        Console.WriteLine("Enter your number");
        //        userNumber = int.Parse(Console.ReadLine());
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Enter Valid Number");
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }

        //    switch (userNumber)
        //    {
        //        case 10:
        //        case 20:
        //        case 30:
        //            Console.WriteLine("Your number is {0}", userNumber);
        //            break;
        //        default:
        //            Console.WriteLine("Enter number is other than 10, 20 and 30");
        //            break;
        //    }


        //} 
        #endregion

    }
}