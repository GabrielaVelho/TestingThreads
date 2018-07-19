using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteThreads
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int j;

            /* Criar duas threads, cada uma faz print de alguma coisa e depois sleep*/
            var Gato = new Thread(() => {
                for(i = 0; i < 4; i++)
                {
                    Console.WriteLine("Miau...");
                    Thread.Sleep(1000);
                }
            });

            var Panda = new Thread(() =>
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("Panda comendo...");
                    Thread.Sleep(1000);
                }
            });

            Gato.Start();
            Panda.Start();
            Gato.Join();

            Console.ReadLine();

            /*Criar duas threads. A primeira faz alguma tarefa e depois espera a segunda concluir alguma tarefa*/
        }
    }
}
