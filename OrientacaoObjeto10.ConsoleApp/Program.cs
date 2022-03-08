using System;

namespace OrientacaoObjeto10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno medias = new Aluno();
            medias.p1 = 5;
            medias.p2 = 5;
            
            medias.n1 = 5;
            medias.n2 = 6;
           

            Console.WriteLine($"A media ponderada do aluno é de: {medias.Media()}");
            Console.ReadLine();
        }
    }
}
