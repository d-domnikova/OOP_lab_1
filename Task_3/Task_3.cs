class Average
{
    static void Main()
    {
        //problem 8
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double average = (double)(a + b + c) / 3;
        Console.WriteLine(average);

        //problem 9
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double area = (double)(a+b)/2*h;
        Console.WriteLine(area);

        //problem 10
        int n = int.Parse(Console.ReadLine());
        int lastDigid = n % 10;
        Console.WriteLine(lastDigid);

        //problem 11
        
        int number = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine()) ;
        int nDigit = (number /10 ^ (n - 1))%10;
        Console.WriteLine(nDigit);

        //problem 12
        n = int.Parse(Console.ReadLine());
        Boolean result;
        if (n>20 && (n%2==1)) 
        {
            result = true;
        } else
        {
            result = false;
        }
        Console.WriteLine(result);
        
        //problem 13
        n = int.Parse(Console.ReadLine());
         Boolean output;
        if (n%9==0 || n%11==0 || n % 13 == 0)
        {
            output = true;
        } else
        {
            output = false;
        }
        Console.WriteLine(output);
    }
}