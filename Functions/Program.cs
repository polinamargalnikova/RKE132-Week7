
Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
    PrintHelllo();
}
else
{
    PrintGoodBye();
}


//PrintHelllo();
//PrintGoodBye();

static void PrintHelllo()    //function metood
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator");
}

