using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console01
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int variabile;
            string parola;
            
            variabile = 10;

            Console.WriteLine(variabile);
            parola = Console.ReadLine();

            Console.WriteLine("hai scritto la parola: " + parola);

            // converto la variabile stringa in integer
            variabile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hai inserito la parola: " + variabile);

            

            int num1;
            int num2;
            int somma;

            */

            /*
            float num1;
            float num2;
            float risultato;
            float x;


            Console.WriteLine("Inserisci il promo numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il promo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());


            risultato = num1 / num2;
            Console.WriteLine("la somma è " + risultato);

            Console.WriteLine("Inserisci il numero con la virgola : ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hai inserito: " + x);
            Console.ReadKey();
            */


            int num1;
            int num2;

            Console.WriteLine("Inserisci il promo numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("il primo numero è maggore del secondo:");
            } 
            else if (num1 == num2) 
            { 
                Console.WriteLine("I due numeri sono uguali");
            }
            else 
            {
                Console.WriteLine("il secondo numero è maggore del secondo:");
            }
            Console.ReadKey();
        }
    }
}
