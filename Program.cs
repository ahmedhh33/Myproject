namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte");
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("sbyte");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("short");
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("ushort");
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("int");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("uint");
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("long");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("=============");


            Console.WriteLine("ulong");
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("flout");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("double");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("decimal");
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine("=============");

            Console.WriteLine("char");
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine("=============");

            /*Console.WriteLine("string");
            Console.WriteLine(string.MaxValue);
            Console.WriteLine(string.MinValue);
            Console.WriteLine("=============");*/

            Console.WriteLine("*");
            Console.WriteLine(" *");
            Console.WriteLine("  *");
            Console.WriteLine("   *");
            Console.WriteLine("   *");
            Console.WriteLine("  *");
            Console.WriteLine(" *");
            Console.WriteLine("*");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine("");
            }
            for (int i = 4; i>=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine("");
            }

            Console.WriteLine("anuther kind of batterns");

            for(int i = 1; i<=5;i++)
            {
                for(int j = 5; j>=1 ;j--)
                    { 
                if  (j<=i)
                     Console.Write(j);
                    else
                     Console.WriteLine("");
                    }
                    
            }
        }
    }
}