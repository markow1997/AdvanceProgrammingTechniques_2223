using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();

        // kreator posiada główną logikę biznesową, którą przenosi dalej poprzez factoryMethod()
        // podklasy mogą tą metodę nadpisać

        public string exampleOperation()
        {
            var exampleProduct = FactoryMethod();
            var result = "Wytworzone przez klasa Creator i " + exampleProduct.Operation();
            return result;
        }
    }

    class Creator1 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product1();
        }
    }
    class Creator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product2();
        }
    }

    public interface Product
    {
        string Operation();
    }

    class Product1 : Product
    {
        public string Operation()
        {
            return "Zwracany Produkt1";
        }
    }
    class Product2 : Product
    {
        public string Operation()
        {
            return "Zwracany Produkt2";
        }
    }

    
    class Client
    {
        public void Main()
        {

            ClientCode(new Creator1());
            ClientCode(new Creator2());

        }
        public void ClientCode(Creator c)
        {
            Console.WriteLine("Zostało użyte  - "+c.exampleOperation());
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.ReadKey();
        }
    }
}
