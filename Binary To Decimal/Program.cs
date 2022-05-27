using System;
namespace Binary2Decimal
{
    class program
    {
        static void Main(string[] args)
        {
            int[] binary = { 1,0,0,1,0,1,0,1,1,0 };
            int[] stored = new int[10];
            for (int i = 0; i < binary.Length; i++)
            {
               int result = 0 * 2 + binary[i];
                stored[i] = result;

                Console.WriteLine(stored[i]);
                if (true) {
                    switch { 
                        case "0":
                            0 * 2 + 1;
                            break;
                        case "1":
                            1 * 2 + 1;
                            break;
                    }
                   
                   
                }
            }
        }
    }
}