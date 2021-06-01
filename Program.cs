using System;
using System.Collections.Generic;
using statusJogador.Classes;

namespace statusJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JogadorStatus> jogadores = new List<JogadorStatus>();
            
            Console.WriteLine("1° Tempo");
            jogadores.Add(new JogadorStatus("Caio", 15, 9, 3) );
            jogadores.Add(new JogadorStatus("Vinicius", 23, 4, 5) );
            jogadores.Add(new JogadorStatus("Gomes", 10, 6, 18) );

            foreach (JogadorStatus item in jogadores)
            {
                Console.WriteLine($"Nome: {item.Nome} - Pts: {item.Pontos} - Ass: {item.Assistencias} - Reb: {item.Rebotes}");
            }

            JogadorStatus atualizacao = jogadores.Find(item => item.Nome == "Caio");
            atualizacao.Pontos = 32;
            atualizacao.Assistencias = 18;
            atualizacao.Rebotes = 5;

            jogadores.RemoveAll(item => item.Nome == "Caio");

            jogadores.Insert(0, atualizacao);

            JogadorStatus atualizacao2 = jogadores.Find(item => item.Nome == "Vinicius");
            atualizacao2.Pontos = 43;
            atualizacao2.Assistencias = 11;
            atualizacao2.Rebotes = 8;

            jogadores.RemoveAll(item => item.Nome == "Vinicius");

            jogadores.Insert(1, atualizacao2);

            JogadorStatus atualizacao3 = jogadores.Find(item => item.Nome == "Gomes");
            atualizacao3.Pontos = 25;
            atualizacao3.Assistencias = 9;
            atualizacao3.Rebotes = 37;

            jogadores.RemoveAll(item => item.Nome == "Gomes");

            jogadores.Insert(2, atualizacao3);

            foreach (JogadorStatus item in jogadores)
            {
                Console.WriteLine($"Nome: {item.Nome} - Pts: {item.Pontos} - Ass: {item.Assistencias} - Reb: {item.Rebotes}");
            }
        }
    }
}
