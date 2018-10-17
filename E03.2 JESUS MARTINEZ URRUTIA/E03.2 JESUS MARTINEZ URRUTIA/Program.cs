using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03._2_JESUS_MARTINEZ_URRUTIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Cola = new Queue();//Se crea un elemento Queue
            Cola.Enqueue(1);//Se agrega el número 1 a la cola
            Cola.Enqueue(2);//Se agrega el número 2 a la cola
            Cola.Enqueue(3);//Se agrega el número 3 a la cola
            foreach (Object obj in Cola)
            {
                Console.WriteLine(obj);//Se imprimen los elementos de la cola
            }
            Cola.Dequeue();//Se elimine el primer elemento agregado a la cola
            foreach (Object obj in Cola)
            {
                Console.WriteLine(obj);//Se imprimen los elementos restantes de la cola
            }
            Console.ReadKey();
        }
    }
}
