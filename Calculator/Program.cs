
Console.WriteLine("Enter the operation (+/-): ");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstnum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstnum, secondNum);
        break;
    case '-':
        Subtraction(firstnum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}