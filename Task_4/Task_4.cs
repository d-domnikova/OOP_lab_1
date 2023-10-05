class Conditional_Statemens
{
    static void Main()
    {
        //problem 14

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max;

        if (a > b && a > c)
        {
            max = a;
        } else if (b > a && b > c) 
        {
            max = b;
        } else
        {
            max = c;
        }
        Console.WriteLine(max);


        //problem 15
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        int product=0;

        if (a < 0)
        {
            product++;
        }
        if (b < 0)
        {
            product++;
        }
        if (c < 0)
        {
            product++;
        }

        if (product == 1|| product==3) 
        {
            Console.WriteLine("negative");
        } else 
        {
            Console.WriteLine("positive");
        }

        //problem 16
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("not valid");
                break;
        }
    }
}