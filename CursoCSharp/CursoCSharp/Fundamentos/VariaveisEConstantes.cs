using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é :" + area);
            

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor inteiro é: " + menorValorInt);

            uint populacaoBrasileira = 207_000_000;
            Console.WriteLine("População brasileira é: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é: " + precoComputador);

            double valorDeMercadoDaApple = 1000000000000.00;
            Console.WriteLine("Valor de mercado da Apple é: " + valorDeMercadoDaApple); //Mais usados dos reais

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância entre estrelas é: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo!";
            Console.WriteLine("Texto é: " + texto);

            Console.Read();
        }
    }
}
