using System;
using System.Collections;


namespace BitArrayExample
{
    public class Example
    {
        public static void Main()
        {
            BitArray bArr1 = new BitArray(15);
            BitArray bArr2 = new BitArray(5);

            bArr2.Set(0, true);
            bArr2.Set(1, false);
            bArr2.Set(2, true);
            bArr2.Set(3, true);
            bArr2.Set(4, false);

            for (int i = 0; i < bArr2.Count; i++)
            {
                Console.Write(bArr2[i]);
                Console.Write(" ");
            }
            Console.WriteLine("\n\nbArr1.Length Length: {0}", bArr1.Length);
            Console.WriteLine("bArr2.Length Length: {0}", bArr2.Length);


        }
    }

}
