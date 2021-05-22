using System;
using System.Collections;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14.1.1
            //შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
            //დინამიურ მასივს დაუმატეთ ორი სტრიქონი. ეკრანზე გამოიტანეთ დინამიურ მასივში
            //ელემენტების რაოდენობა და თვით დინამიური მასივი.

            string[] elements = new string[] { "Element1", "Element2", "Element3", "Element4", "Element5", "Element6", "Element7", "Element8", "Element9", "Element10" };

            ArrayList arrList = new ArrayList(elements);
            arrList.Add("randElement1");
            arrList.Add("randElement2");

            Console.WriteLine("\n-------The array elements-------");

            foreach (var item in arrList)
                Console.Write(item + ", ");

            Console.WriteLine("\n\nNumber of elements in the array: {0}", arrList.Count);

        }
    }
}
