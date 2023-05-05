using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Você está em uma floresta e seu objetivo é encontrar o tesouro escondido. Você está pronto para começar?");
        Console.WriteLine("Digite 'sim' para começar ou 'não' para sair.");
        string resposta = Console.ReadLine();

        if (resposta == "sim")
        {
            Console.WriteLine("Você está caminhando pela floresta e encontra um rio. Você deve atravessá-lo. O que você faz?");
            Console.WriteLine("1. Tenta atravessar a nado.");
            Console.WriteLine("2. Procura uma ponte para atravessar.");
            Console.WriteLine("3. Desiste e volta para a floresta.");

            int escolha1 = Convert.ToInt32(Console.ReadLine());

            if (escolha1 == 1)
            {
                Console.WriteLine("Você tenta atravessar a nado e é arrastado pela correnteza. Game Over.");
            }
            else if (escolha1 == 2)
            {
                Console.WriteLine("Você encontra uma ponte e a atravessa com sucesso. Você continua caminhando pela floresta e encontra um baú. O que você faz?");
                Console.WriteLine("1. Abre o baú.");
                Console.WriteLine("2. Ignora o baú e continua caminhando.");

                int escolha2 = Convert.ToInt32(Console.ReadLine());

                if (escolha2 == 1)
                {
                    Console.WriteLine("Você abre o baú e encontra uma espada. Você pega a espada e continua caminhando pela floresta.");
                }
                else if (escolha2 == 2)
                {
                    Console.WriteLine("Você ignora o baú e continua caminhando.");
                }

                Console.WriteLine("Você encontra um rio. Você deve atravessá-lo. O que você faz?");
                Console.WriteLine("1. Tenta atravessar a nado.");
                Console.WriteLine("2. Procura uma ponte para atravessar.");
                Console.WriteLine("3. Desiste e volta para a floresta.");

                int escolha3 = Convert.ToInt32(Console.ReadLine());

                if (escolha3 == 1)
                {
                    Console.WriteLine("Você tenta atravessar a nado e é arrastado pela correnteza. Game Over.");
                }
                else if (escolha3 == 2)
                {
                    Console.WriteLine("Você encontra uma ponte e a atravessa com sucesso. Você continua caminhando pela floresta e encontra uma clareira. Você vê uma placa que aponta para duas direções.");
                    Console.WriteLine("1. Segue a direção da esquerda.");
                    Console.WriteLine("2. Segue a direção da direita.");

                    int escolha4 = Convert.ToInt32(Console.ReadLine());

                    if (escolha4 == 1)
                    {
                        Console.WriteLine("Você segue pela direção da esquerda e encontra uma caverna. Você entra na caverna e encontra o tesouro. Parabéns, você venceu o jogo!");
                    }
                    else if (escolha4 == 2)
                    {
                        Console.WriteLine("Você segue pela direção da direita e encontra um grupo de inimigos. Você tenta lutar, mas é morto. Game Over.");
                    }
                }
            }
        }
    }
}