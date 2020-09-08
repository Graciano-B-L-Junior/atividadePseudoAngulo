using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa Vector");
            Vetores v1 = new Vetores(5, 4, 0);

            Console.WriteLine("Encontrando angulo entre dois vetores usando produto escalar");
            Vetores v2 = new Vetores(5, 14, 0);
            var produtoEscalar = v1.produtoEscalar(v2);
            var produtoDasNormas = v1.comprimentoVetor() * v2.comprimentoVetor();
            var angulo = MathF.Acos(produtoEscalar / produtoDasNormas);
            angulo *= 180 / MathF.PI;
            Console.WriteLine("Angulo em graus "+ angulo);

            Console.WriteLine();

            Console.WriteLine("Encontrando angulo entre dois vetores usando produto vetorial");
            var numeradorProdutoEscalar = v1.produtoVetorial(v2);
            var numerador = numeradorProdutoEscalar.comprimentoVetor();
            var denominador = v1.comprimentoVetor() * v2.comprimentoVetor();
            var angulo2 = MathF.Asin(numerador / denominador);
            angulo2 *= 180 / MathF.PI;
            Console.WriteLine("Angulo em graus " + angulo2);

        }
    }
}
