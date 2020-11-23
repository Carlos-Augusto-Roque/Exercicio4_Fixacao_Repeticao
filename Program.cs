using System;

namespace Exercicio4_Fixacao_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[15];//array para receber e armazenar os números em 15 posições

            for (var i = 0; i < 15; i++) // estrutura de repetição do tipo for 
            {

            Console.WriteLine("Digite o número: ");//exibição da mensagem
            numeros[i] = float.Parse(Console.ReadLine());//entrada e armazenamento dos números
                
            }

            Console.WriteLine("Veja abaixo a lista dos números na ordem inversa: ");//exibição da mensagem 

            Array.Reverse(numeros);//comando para inverter o array
            
            foreach(float lista in numeros)//exibir o array em lista 
            {
                Console.WriteLine(lista);
                
            }
            
                       
        }

    }
}
// Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.