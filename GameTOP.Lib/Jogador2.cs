using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        
        public readonly string _Nome;

        public string Chuta()
        {
            return "Maradona estas Pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas Corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas Pasando \n";
        }
    }
}