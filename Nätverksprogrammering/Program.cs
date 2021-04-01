using System;

namespace Nätverksprogrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte[] textBytes = Encoding.unicode.GetBytes("hej");
            string text = Encoding.Unicode.Getstring(textBytes);
            byte[] talBytes = BitConverter.GetBytes(7);
            int tal = BitConverter.ToInt32(talBytes, 0);
        }
    }
}
