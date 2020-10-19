using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Ana");
            lista.Insert(2, "Marco");

            foreach(string ob in lista)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("Tamanho da lista: " + lista.Count);

            //.Find ou .FindLast - predicado
            string s1 = lista.Find(x => x[0] == 'A');
            string s2 = lista.FindLast(x => x[0] == 'A');

            Console.WriteLine("Primeiro da lista cm início A: " + s1);
            Console.WriteLine("Ultimo da lista cm início A: " + s2);

            //Achar o index ao invés do valor> FindIndex - FindLastIndex
            int pos = lista.FindIndex(x => x[0] == 'A');

            //Filtrar lista a partir de predicado - FindAll
            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            //Remover itens
            lista.Remove("Alex");
            lista.RemoveAll(x => x[0] == 'M');
            lista.RemoveAt(2);
            lista.RemoveRange(2, 3); // a partir da posição 2, remover 3 elementos.


        }
    }
}
