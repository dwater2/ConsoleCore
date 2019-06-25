using System;
using GameTOP.Interface;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador1("Donizete"),
                new Jogador2())
                ;
            jogo.IniciarJogo();
        }
    }


    class JogoFoda{

        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        public JogoFoda(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo(){
            Console.Write(_jogador1.Corre());
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Passe());

            Console.Write("\n PRÓXIMO JOGODOR \n");

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passe());
        }
    }


}
