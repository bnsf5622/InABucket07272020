using System;

namespace InABucket07272020
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can declare all KINDS of varibles.
            String walrus;
            double piesEaten;
            float weightOfTeaCupPig;
            int grainsOfSnd;

            // But declaing them just sets up the spce for data
            // to use 
            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;

            Console.WriteLine("Meet  my pet Walrus, " + walrus);
            Console.Write("He was a bit hungry today, and ate this many pies : ");
            Console.WriteLine(piesEaten);
        }
    }
}