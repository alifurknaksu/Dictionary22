using System;

namespace Dictionary22
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("1579", "Elif Duru");
            myDictionary.Add("4565", "Kaan Alp");
            myDictionary.Add("6879", "Selcen Akarsu");



            foreach (var IdNo in myDictionary.Keys)
            {
                Console.WriteLine(IdNo + " : Aranıyor... ");

            }

            foreach (var Isim in myDictionary.Values)
            {
                Console.WriteLine("Eşleşen Isim: " + Isim);
            }

        }
    }
}