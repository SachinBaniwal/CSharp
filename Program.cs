using System;
namespace HelloWorld
{
    class yel
    {
        public int add(int a, int b)
        {
            Console.WriteLine("In Add Function");
            return a + b;
        }

        public static void Main(string[] args)
        {
            yel obj = new yel();
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.WriteLine("The string is: " + str);
            int ar= str.Length;
            Console.Write("Reverse of the string is: ");
            for(int i=ar-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Addition of Two Numbers: "+ obj.add(5,10));
            Console.WriteLine("Again in Main Functions");
        }
    }
}