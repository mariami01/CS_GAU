using System;
using System.Collections;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //14.1.2. შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
            //დინამიური მასივიდან წაშალეთ სამი სტრიქონი. ეკრანზე გამოიტანეთ დინამიურ მასივში 
            //ელემენტების რაოდენობა და თვით დინამიური მასივი.


            string[] elements = new string[] { "myElement1", "myElement2", "myElement3", "myElement4", "myElement5", "myElement6", "myElement7", "myElement8", "myElement9", "myElement10" };

            ArrayList arrList = new ArrayList(elements);

            Console.WriteLine("-------The elements in ArrayList initially are-------");

            foreach (var item in arrList)
                Console.Write(item + ", ");

            arrList.RemoveAt(4);
            arrList.RemoveAt(7);

            Console.WriteLine("\n\n-------The elements in ArrayList are-------");

            foreach (var item in arrList)
                Console.Write(item + ", ");

            Console.WriteLine("\n\nNumber of elements in the array: {0}", arrList.Count);
        }
    }
}
