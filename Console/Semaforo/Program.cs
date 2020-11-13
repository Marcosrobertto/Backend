using System;

namespace Semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cor do semaforo");
            string cor = (Console.ReadLine());

            if(cor == "Vermelho" | cor == "vermelho") {
                Console.WriteLine("Pare o carro agora.");
            } else if(cor == "Amarelo" | cor == "amarelo") {
                Console.WriteLine("Diminua a velocidade e pare o carro agora.");
            } else{
                Console.WriteLine("Continue acelerando");
            }


        }
    }
}
