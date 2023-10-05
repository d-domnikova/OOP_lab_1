class Variables
{
    static void Main()
    {
        //problem 5
        sbyte integer_var1 = -100;
        byte integer_var2 = 128;
        short integer_var3 = -3540;
        ushort integer_var4 = 64876;
        uint integer_var5 = 2147483648;
        int integer_var6 = -1141583228;
        long integer_var7 = -1223372036854775808;

        Console.WriteLine(integer_var1 + "\n" + integer_var2 + "\n" + integer_var3 + "\n" 
            + integer_var4 + "\n" + integer_var5 + "\n" + integer_var6 + "\n" + integer_var7);

        //problem 6
        double point_var1 = 3.141598653589793238;
        double point_var2 = 1.60217657;
        double point_var3 = 7.8184261974584555216535342341;

        Console.WriteLine("\n" + point_var1 + "\n" + point_var2 + "\n" + point_var3);

        //problem 7
        string values1 = "Softwart University";
        char values2 = 'B';
        char values3 = 'y';
        char values4 = 'e';
        string values5 = "I love programming";

        Console.WriteLine("\n" + values1 + "\n" + values2 + "\n" + values3 + "\n" + values4 + "\n" + values5);
    }
}